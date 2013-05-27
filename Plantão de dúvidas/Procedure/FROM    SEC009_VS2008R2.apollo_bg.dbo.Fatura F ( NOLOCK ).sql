--CodDiv=10&CodReg=0&CodSubReg=0&CodUnd=0&TipVeiculo=0&CodDespachante=0&DataInicial=2012-01-29&DataFinal=2012-01-31

--SELECT top 100 * FROM dbo.tbUnidade WHERE /*NomFanUnd LIKE '%jac%consola%'*/ CodUnd = 53
--SELECT top 100 * FROM tbRegional_Unidade WHERE CodUnd = 51 and CodDiv  = 10
--SELECT top 100 * FROM dbo.tbRegional WHERE CodDiv = 10 AND codreg = 14
--SELECT top 100 * FROM tbSetorUnidade WHERE CodDiv = 10 AND CodUnd = 51
--SELECT top 100 * FROM dbo.tbSetor WHERE CodSetor = 25
 
DECLARE @CodDiv INT 
SET @CodDiv = 10
DECLARE @CodReg INT 
SET @CodReg = 0
DECLARE @CodSubReg INT 
SET @CodSubReg = 0
DECLARE @CodUnd INT 
SET @CodUnd = 0
DECLARE @TipVeiculo SMALLINT 
SET @TipVeiculo = 0
DECLARE @CodDespachante INT 
SET @CodDespachante = 0
DECLARE @DataInicial varchar(10) 
SET @DataInicial = '2012-01-01'
DECLARE @DataFinal varchar(18) 
SET @DataFinal = '2012-01-31 23:59:59'

SELECT /*PD.Numero, tbUnid.InsCnpj,*/ --*
        tbRegi.CodReg,
        tbSetorUnd.CodSetor,
        tbUnid.CodUnd,
        Count(F.Id) QtdFat,
        P.NomeFantasia
FROM    
		--=========================================================================================
		-- Apollo
		-------------------------------------------------------------------------------------------
        SEC009_VS2008R2.apollo_bg.dbo.Fatura F ( NOLOCK )
        INNER JOIN SEC009_VS2008R2.apollo_bg.dbo.Venda V ( NOLOCK ) ON F.venda_id = V.id
        INNER JOIN SEC009_VS2008R2.apollo_bg.dbo.ItemVenda IV ( NOLOCK ) ON IV.venda_id = V.id
                                                                            AND IV.TipoProduto_id IN ( 1, 2, 3, 4 )
        INNER JOIN SEC009_VS2008R2.apollo_bg.dbo.Concessionaria C ( NOLOCK ) ON C.id = V.concessionaria_id
        INNER JOIN SEC009_VS2008R2.apollo_bg.dbo.Pessoa P ( NOLOCK ) ON P.Id = C.Pessoa_id
        --INNER JOIN SEC009_VS2008R2.apollo_bg.dbo.PessoaDocumento PD ( NOLOCK ) ON C.Pessoa_id = PD.Pessoa_id AND PD.Tipo = 4 -- CNPJ
		-------------------------------------------------------------------------------------------
        INNER JOIN dbo.tbUnidade tbUnid ( NOLOCK ) ON tbUnid.SglApollo = C.Sigla AND tbunid.SitUnd = 'A' -- Consolação, por exemplo, tem a mesma sigla Apollo duas vezes

        --INNER JOIN dbo.tbPfcDespachante PFCDesp ( NOLOCK ) ON PFCDesp.NroPFC = V.Id
        --                                                      AND PFCDesp.CodUnd = tbUnid.CodUnd
		-------------------------------------------------------------------------------------------
		-- Joins chatos com as tbSaoPedro
		-------------------------------------------------------------------------------------------
        INNER JOIN dbo.tbRegional_Unidade RegUnd ( NOLOCK ) ON /*RegUnd.CodReg = tbRegi.CodReg
                                                               AND*/ RegUnd.CodUnd = tbUnid.CodUnd AND RegUnd.CodDiv = @CodDiv
        INNER JOIN dbo.tbRegional tbRegi ( NOLOCK ) ON tbRegi.CodReg = RegUnd.CodReg AND tbRegi.CodDiv = @CodDiv
        INNER JOIN dbo.tbSetorUnidade tbSetorUnd ( NOLOCK ) ON tbSetorUnd.CodUnd = RegUnd.CodUnd
                                                               AND tbSetorUnd.CodDiv = RegUnd.CodDiv
        INNER JOIN dbo.tbSetorVisao tbSetorV ( NOLOCK ) ON tbSetorV.CodSetorVisao = tbSetorUnd.CodSetorVisao
                                                           AND tbSetorV.FlgVisaoAtual = 1 
        INNER JOIN dbo.tbSetor tbSetor ( NOLOCK ) ON tbSetor.CodSetor = tbSetorUnd.CodSetor And tbSetor.CodSetorVisao = tbSetorV.CodSetorVisao   
		-------------------------------------------------------------------------------------------
WHERE   ( RegUnd.CodDiv = @CodDiv
          OR @CodDiv = 0
        )
        AND ( tbRegi.CodReg = @CodReg
              OR @CodReg = 0
            )
        AND ( tbSetorUnd.CodSetor = @CodSubReg
              OR @CodSubReg = 0
            )
        AND ( tbUnid.CodUnd = @CodUnd
              OR @CodUnd = 0
            )
        AND ( ( iv.TipoProduto_id = @TipVeiculo
                OR @TipVeiculo = 0
              )
              OR ( ( iv.TipoProduto_id IN ( 2, 3, 4 )
                     AND @TipVeiculo = 2
                   )
                   OR @TipVeiculo = 0
                 )
            )
        --AND ( PFCDesp.CodDespachante = @CodDespachante
        --      OR @CodDespachante = 0
        --    )
        AND f.DataFaturamento IS NOT NULL
        AND f.DataCancelamento IS NULL
        AND F.TipoFatura = 1 -- Venda
        AND ( ( v.DataFaturamento > @DataInicial
              AND v.DataFaturamento < @DataFinal
              )
              --OR ( appfc.DhrInc > @DataInicial
              --     AND appfc.DhrInc < @DataFinal
              --   )
              
            )
GROUP BY tbRegi.CodReg, tbSetorUnd.CodSetor, tbUnid.CodUnd  ,P.NomeFantasia
ORDER BY P.NomeFantasia