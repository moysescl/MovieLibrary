using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using MovieLibrary.BUS;


namespace MovieLibrary.GUI
{
    public partial class MovieLibraryForm : Form
    {
        List<BUS.MovieLibrary> myMovieList = new List<BUS.MovieLibrary>();
        int index;
        static String path = @"../../data/txtFile.txt";
        static String binPath = @"../../data/bankHH.bin";
        public MovieLibraryForm()
        {
            InitializeComponent();
        }
        public static void ValidateDigit(KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show(" Must be a digit only  \n Message from ValidateDigit operation..");
                //e.KeyChar = ' ';
                e.Handled = true;
            }
        }
        private void MovieLibraryForm_Load(object sender, EventArgs e)
        {
            foreach (EnumMovieGenre element in Enum.GetValues(typeof(EnumMovieGenre)))
            {
                comboBoxGenre.Items.Add(element);
            }
            comboBoxGenre.Text = Convert.ToString(comboBoxGenre.Items[0]);
            foreach (EnumCountry element in Enum.GetValues(typeof(EnumCountry)))
            {
                comboBoxCountry.Items.Add(element);
            }
            comboBoxCountry.Text = Convert.ToString(comboBoxCountry.Items[0]);
            foreach (EnumLanguage element in Enum.GetValues(typeof(EnumLanguage)))
            {
                comboBoxLanguage.Items.Add(element);
            }
            comboBoxLanguage.Text = Convert.ToString(comboBoxLanguage.Items[0]);
        }

        private void listViewMovieLibrary_SelectedIndexChanged(object sender, EventArgs e)
        {


            index = listViewMovieLibrary.FocusedItem.Index;
            MessageBox.Show("selected index: " + index);
            this.textBoxNumber.Text = Convert.ToString(myMovieList[index].Number);
            this.textBoxTitle.Text = myMovieList[index].Title;
            this.comboBoxGenre.Text = Convert.ToString(myMovieList[index].Genre);
            this.comboBoxCountry.Text = Convert.ToString(myMovieList[index].Country);
            this.comboBoxLanguage.Text = Convert.ToString(myMovieList[index].Language);
            this.textBoxDuration.Text = Convert.ToString(myMovieList[index].Duration);
            // this.textBoxYear.Text =Convert.ToString(myMovieList[index].RelDate);
            this.textBoxYear.Text = Convert.ToString(myMovieList[index].RelDate.Year);
            dateTimePickerRegDate.Value =
                            DateTime.Parse(Convert.ToString(myMovieList[index].RegDate));
        }

        private void MovieLibrary_Load(object sender, EventArgs e)
        {

        }

        
        private void buttonAdd_Click(object sender, EventArgs e)
        {

            BUS.MovieLibrary anMovie = new BUS.MovieLibrary(); //declaration & initialization        
            Date reldate = new Date();
            String input;
            String input2;
            int number;
            String title;
            int duration;
            // int year;
            // String y;
            title = textBoxTitle.Text;


            reldate.Year = Convert.ToInt32(this.textBoxYear.Text);

            BUS.EnumCountry country;
            BUS.EnumLanguage language;
            BUS.EnumMovieGenre genre;
            input = textBoxNumber.Text;
            number = Convert.ToInt32(input);
            input2 = textBoxDuration.Text;
            duration = Convert.ToInt32(input2);
            // y = textBoxYear.Text;
            // year = Convert.ToInt32(y);

            genre = (BUS.EnumMovieGenre)comboBoxGenre.SelectedIndex;
            country = (BUS.EnumCountry)comboBoxCountry.SelectedIndex;
            language = (BUS.EnumLanguage)comboBoxLanguage.SelectedIndex;
            anMovie.Number = number;
            anMovie.Title = title;
            anMovie.Genre = genre;
            anMovie.Country = country;
            anMovie.Duration = duration;
            anMovie.Language = language;
            anMovie.RelDate = reldate;
            anMovie.RegDate = this.dateTimePickerRegDate.Value;
            this.myMovieList.Add(anMovie);
            textBoxCounter.Text = Convert.ToString(BUS.MovieLibrary.Counter);
        }

        private void dateTimePickerRegDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxGenre.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxCountry.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void comboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            if (this.myMovieList.Capacity != 0)
            {
                foreach (BUS.MovieLibrary element in myMovieList)
                {
                    ListViewItem item = new ListViewItem(Convert.ToString(element.Number));
                    item.SubItems.Add(element.Title);
                    item.SubItems.Add(Convert.ToString(element.Genre));
                    item.SubItems.Add(Convert.ToString(element.Country));
                    item.SubItems.Add(Convert.ToString(element.Language));
                    item.SubItems.Add(Convert.ToString(element.Duration));
                    item.SubItems.Add(Convert.ToString(element.RelDate.Year));
                    item.SubItems.Add(Convert.ToString(element.RegDate));


                    this.listViewMovieLibrary.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("...NO DATA.....");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hi.. We are updating the record : " + index);
            this.myMovieList[index].Number = Convert.ToInt32(textBoxNumber.Text);
            this.myMovieList[index].Genre = (EnumMovieGenre)comboBoxGenre.SelectedIndex;
            this.myMovieList[index].Country = (EnumCountry)comboBoxCountry.SelectedIndex;
            this.myMovieList[index].Language = (EnumLanguage)comboBoxLanguage.SelectedIndex;
            this.myMovieList[index].Duration = Convert.ToInt32(textBoxDuration.Text);
            this.myMovieList[index].RelDate.Year = Convert.ToInt32(textBoxYear.Text);
            this.myMovieList[index].RegDate = this.dateTimePickerRegDate.Value;
            MessageBox.Show("record updated...");
            this.listViewMovieLibrary.Items.Clear();
            foreach (BUS.MovieLibrary element in myMovieList)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(element.Number));
                item.SubItems.Add(element.Title);
                item.SubItems.Add(Convert.ToString(element.Genre));
                item.SubItems.Add(Convert.ToString(element.Country));
                item.SubItems.Add(Convert.ToString(element.Language));
                item.SubItems.Add(Convert.ToString(element.Duration));
                item.SubItems.Add(Convert.ToString(element.RelDate.Year));
                item.SubItems.Add(Convert.ToString(element.RegDate));
                this.listViewMovieLibrary.Items.Add(item);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxNumber.Text = "";
            textBoxTitle.Text = "";
            comboBoxGenre.Text = Convert.ToString(EnumMovieGenre.Undefined);
            comboBoxCountry.Text = Convert.ToString(EnumCountry.Undefined);
            comboBoxLanguage.Text = Convert.ToString(EnumLanguage.Undefined);
            textBoxDuration.Text = "";
            textBoxYear.Text = "";
            this.dateTimePickerRegDate.Value = DateTime.Now;
            textBoxNumber.Focus();
            this.listViewMovieLibrary.Items.Clear();
            textBoxSearch.Text = "";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            if (listViewMovieLibrary.FocusedItem.Index >= 0)
            {
                myMovieList.RemoveAt(listViewMovieLibrary.FocusedItem.Index);
                
            }
            this.listViewMovieLibrary.Items.Clear();
            foreach (BUS.MovieLibrary element in myMovieList)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(element.Number));

                item.SubItems.Add(element.Title);
                item.SubItems.Add(Convert.ToString(element.Genre));
                item.SubItems.Add(Convert.ToString(element.Country));
                item.SubItems.Add(Convert.ToString(element.Language));
                item.SubItems.Add(Convert.ToString(element.Duration));
                item.SubItems.Add(Convert.ToString(element.RelDate.Year));
                item.SubItems.Add(Convert.ToString(element.RegDate));
                this.listViewMovieLibrary.Items.Add(item);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            bool found = false;
            BUS.MovieLibrary oneMovie = new BUS.MovieLibrary();

            foreach (BUS.MovieLibrary element in this.myMovieList)
            {
                if (element.Number == Convert.ToInt32(textBoxSearch.Text))
                {
                    found = true;

                    oneMovie = element;

                }
            }
            if (found)
            {
                MessageBox.Show("Account Found...");
                MessageBox.Show(oneMovie.Number + "\t" + oneMovie.Title);
            }
            else
            {
                MessageBox.Show("..Account NOT Found...");
            }
        }

        private void buttonWriteTxt_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = File.CreateText(path))
            {
                foreach (BUS.MovieLibrary anMovie in this.myMovieList)
                {

                    writer.WriteLine(anMovie.Number + "|" + anMovie.Title + "|" + anMovie.Genre + "|" + anMovie.Country + "|" + anMovie.Language + "|" + anMovie.Duration + "|" + anMovie.RelDate.Year + "|" + anMovie.RegDate);
                }
            }
        }

        private void buttonReadTxt_Click(object sender, EventArgs e)
        {
            myMovieList.Clear();
            this.listViewMovieLibrary.Items.Clear();

            StreamReader reader = new StreamReader(path);

            String line = null;
            while ((line = reader.ReadLine()) != null)
            {
                BUS.MovieLibrary anMovie = new BUS.MovieLibrary();
                String[] tokens = line.Split('|');
                anMovie.Number = Convert.ToInt32(tokens[0]);
                anMovie.Title = tokens[1];
                anMovie.Genre = (EnumMovieGenre)Enum.Parse(typeof(EnumMovieGenre), tokens[2]);
                anMovie.Country = (EnumCountry)Enum.Parse(typeof(EnumCountry), tokens[3]);
                anMovie.Language = (EnumLanguage)Enum.Parse(typeof(EnumLanguage), tokens[4]);
                anMovie.Duration = Convert.ToInt32(tokens[5]);
                Date anDuration = new Date();
                anDuration.Year = Convert.ToInt32(tokens[6]);
                anMovie.RegDate = DateTime.Parse(tokens[7]);
                myMovieList.Add(anMovie);                             
                anMovie.RelDate = anDuration;              
            }


            foreach (BUS.MovieLibrary element in myMovieList)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(element.Number));            
                item.SubItems.Add(element.Title);
                item.SubItems.Add(Convert.ToString(element.Genre));
                item.SubItems.Add(Convert.ToString(element.Country));
                item.SubItems.Add(Convert.ToString(element.Language));
                item.SubItems.Add(Convert.ToString(element.Duration));
                item.SubItems.Add(Convert.ToString(element.RelDate.Year));
                item.SubItems.Add(Convert.ToString(element.RegDate));
               

                this.listViewMovieLibrary.Items.Add(item);


            }
            reader.Close();
        }

        private void buttonWriteBin_Click(object sender, EventArgs e)
        {
            //FileStream fileStream = new FileStream(binPath, FileMode.OpenOrCreate, FileAccess.Write);
            //BinaryFormatter binFormatter = new BinaryFormatter();

            //binFormatter.Serialize(fileStream, this.myMovieList);
            //fileStream.Close();

            FileStream fs = new FileStream(binPath, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter writer = new BinaryFormatter();

            writer.Serialize(fs, myMovieList);

            fs.Close();

            //FileStream fileStream = new FileStream(binPath, FileMode.OpenOrCreate, FileAccess.Write);
            //BinaryFormatter binFormatter = new BinaryFormatter();

            //binFormatter.Serialize(fileStream, this.myMovieList);
            //fileStream.Close();
        }

        private void buttonReadBin_Click(object sender, EventArgs e)
        {
            if (File.Exists(binPath))
            {
                FileStream fs = new FileStream(binPath, FileMode.Open, FileAccess.Read);
                BinaryFormatter bin = new BinaryFormatter();

                myMovieList = (List<BUS.MovieLibrary>)bin.Deserialize(fs);

                fs.Close();
            }
            foreach (BUS.MovieLibrary element in myMovieList)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(element.Number));
                item.SubItems.Add(element.Title);
                item.SubItems.Add(Convert.ToString(element.Genre));
                item.SubItems.Add(Convert.ToString(element.Country));
                item.SubItems.Add(Convert.ToString(element.Language));
                item.SubItems.Add(Convert.ToString(element.Duration));
                item.SubItems.Add(Convert.ToString(element.RelDate.Year));
                item.SubItems.Add(Convert.ToString(element.RegDate));
                this.listViewMovieLibrary.Items.Add(item);
            }

            

        }
        

        private void textBoxYear_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void textBoxNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateDigit(e);
        }
        private void textBoxYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateDigit(e);
        }

        private void textBoxNumber_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxDuration_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateDigit(e);
        }

        private void textBoxDuration_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

