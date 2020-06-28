using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using XMLGUI.Forms;
using XMLGUI.EventsLib;
using System.Xml.Linq;
using Computers;
using System.Xml.Serialization;
using System.IO;

namespace XMLGUI
{
    public partial class XMLViewer : Form
    {
        private IEnumerable<Computer> items;
        private string[] parametres;
        
        public XMLViewer()
        {
            InitializeComponent();
        }

        private void OnSetFilterClick(object sender, EventArgs e)
        {
            FilterProperties setFilterForm = new FilterProperties();
            setFilterForm.FilterChangeEvent += new EventHandler<FilterChangeEventArgs>(this.OnFilterChangeEvent);
            setFilterForm.Show();
        }

        public void OnFilterChangeEvent(object sender, FilterChangeEventArgs e)
        {
            tableView.Text = "";
            parametres = e.Param.Split('§');

            var filename = "computers.xml";

            XDocument xdoc = XDocument.Load(filename);

            items = from xe in xdoc.Element("ArrayOfComputer").Elements("Computer")
                        where ( (parametres[0] == "Null" || xe.Element("ProcessorType").Value == parametres[0]) &&
                                (parametres[1] == "Null" || xe.Element("RAMSize").Value == parametres[1]) &&
                                (parametres[2] == "Null" || xe.Element("VideoCardMemory").Value == parametres[2]) &&
                                (parametres[3] == "Null" || xe.Element("HardDriveCapacity").Value == parametres[3]))
                        select new Computer
                        {
                            Id = int.Parse(xe.Element("Id").Value),
                            Model = xe.Element("Model").Value,
                            ProcessorType = xe.Element("ProcessorType").Value,
                            ProcessorSpeed = uint.Parse(xe.Element("ProcessorSpeed").Value),
                            RAMSize = uint.Parse(xe.Element("RAMSize").Value),
                            HardDriveCapacity = uint.Parse(xe.Element("HardDriveCapacity").Value),
                            VideoCardMemory = uint.Parse(xe.Element("VideoCardMemory").Value),
                            Price = uint.Parse(xe.Element("Price").Value),
                            CopiesAvailable = uint.Parse(xe.Element("CopiesAvailable").Value),
                        };

            tableView.Text += "id " +
                "Марка".PadRight(10, ' ') +
                "Тип ЦП".PadRight(15, ' ') +
                "Частота ЦП".PadRight(12, ' ') +
                "Объём ОЗУ".PadRight(12, ' ') +
                "Объём SSD".PadRight(12, ' ') +
                "Видеопамять".PadRight(12, ' ') +
                "Цена".PadRight(13, ' ') +
                "В наличии".PadRight(12, ' ') + Environment.NewLine;

            foreach (var item in items)
            {
                tableView.Text += $"{item.Id.ToString().PadLeft(2, '0')} " +
                    $"{item.Model}".PadRight(10, ' ') +
                    $"{item.ProcessorType} ".PadRight(15, ' ') +
                    $"{item.ProcessorSpeed} МГц".PadRight(12, ' ') +
                    $"{item.RAMSize} Гб".PadRight(12, ' ') +
                    $"{item.HardDriveCapacity} Гб".PadRight(12, ' ') +
                    $"{item.VideoCardMemory} Гб".PadRight(12, ' ') +
                    $"{item.Price} у.е.".PadRight(13, ' ') +
                    $"{item.CopiesAvailable} шт.{Environment.NewLine}";
            }
        }

        private void XMLViewer_Load(object sender, EventArgs e)
        {
            tableView.Clear();
            items = Enumerable.Empty<Computer>();
            parametres = new string[] { "Null", "Null", "Null", "Null" };
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableView.Clear();
            items = Enumerable.Empty<Computer>();
            parametres = new string[] { "Null", "Null", "Null", "Null" };
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Computers.Computer>));

            DateTime date = DateTime.Now;

            string filename = Path.Combine(Directory.GetCurrentDirectory(),"FilteredComputers"+date.ToString().Replace(".","").Replace(":", "").Replace(" ","")+".xml");
            tableView.Text += filename;
            
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, items.ToList());
            }
        }

        public void OnDeleteItemEvent(object sender, DeleteItemEventArgs e)
        {
            var filename = "computers.xml";
            
            XDocument xdoc = XDocument.Load(filename);
            
            xdoc.Descendants("ArrayOfComputer")
               .Elements("Computer")
               .Where(x => x.Element("Id").Value == e.Param.ToString())
               .Remove();
            xdoc.Save(filename);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteItem deleteItemForm = new DeleteItem();
            deleteItemForm.DeleteItemEvent += new EventHandler<DeleteItemEventArgs>(this.OnDeleteItemEvent);
            deleteItemForm.Show();
        }

        public void OnInsertItemEvent(object sender, InsertItemEventArgs e)
        {
            var filename = "computers.xml";

            XDocument xdoc = XDocument.Load(filename);
            xdoc.Element("ArrayOfComputer").Add(new XElement("Computer",
                    new XElement("Id",e.Param.Id),
                    new XElement("Model", e.Param.Model),
                    new XElement("ProcessorType", e.Param.ProcessorType),
                    new XElement("ProcessorSpeed", e.Param.ProcessorSpeed),
                    new XElement("RAMSize", e.Param.RAMSize),
                    new XElement("HardDriveCapacity", e.Param.HardDriveCapacity),
                    new XElement("VideoCardMemory", e.Param.VideoCardMemory),
                    new XElement("Price", e.Param.Price),
                    new XElement("CopiesAvailable", e.Param.CopiesAvailable))
                );
            xdoc.Save(filename);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertItem insertItemForm = new InsertItem();
            insertItemForm.InsertItemEvent += new EventHandler<InsertItemEventArgs>(this.OnInsertItemEvent);
            insertItemForm.Show();
        }
    }
}
