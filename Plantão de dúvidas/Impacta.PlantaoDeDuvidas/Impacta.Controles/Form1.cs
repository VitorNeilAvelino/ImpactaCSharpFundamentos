using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Impacta.Controles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PopularTreeView();
        }

        private void PopularTreeView()
        {
            var produtos = XDocument.Load(Application.StartupPath + "\\Produtos.xml");
            treeView1.Nodes.Clear();
            treeView1.Nodes.Add(CreateTreeFromXML(produtos.Root));
        }

        private TreeNode CreateTreeFromXML(XElement elemento)
        {
            TreeNode noh;

            if (elemento.Elements().Count() == 0)
            {
                noh = new TreeNode(elemento.Value);
            }
            else
            {
                noh =  new TreeNode(elemento.Name.ToString(),
                    (from child in elemento.Elements()
                     select CreateTreeFromXML(child)).ToArray());
            } 
            
            noh.ImageIndex = DefinirImagemDoNoh(elemento);
            return noh;
        }

        private static int DefinirImagemDoNoh(XElement elemento)
        {
            var indice = 0;

            if (elemento.Attribute("Tipo") == null) return -1;
            
            if (elemento.Attribute("Tipo").Value == "Acabado")
            {
                indice = 0;
            }
            else if (elemento.Attribute("Tipo").Value == "Fabricado")
            {
                indice = 1;
            }
            return indice;
        }
    }
}