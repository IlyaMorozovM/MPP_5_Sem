using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class FLab1 : Form
    {
        static int dotInNumber = 0;

        static int NumberOfBooks = 0;
        List<Book> Books = new List<Book>();

        public FLab1()
        {
            InitializeComponent();
        }

        public bool isCorrectISBN()
        {
            if (String.IsNullOrWhiteSpace(TISBN.Text) == true)
            {
                MessageBox.Show("ISBN of book is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            return true;
        }

        public bool isCorrectAuthor()
        {
            if (String.IsNullOrWhiteSpace(TAuthor.Text) == true)
            {
                MessageBox.Show("Author of book is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            return true;
        }
        public bool isCorrectName()
        {
            if (String.IsNullOrWhiteSpace(TName.Text) == true)
            {
                MessageBox.Show("Name of book is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            return true;
        }
        public bool isCorrectPrice()
        {
            if (String.IsNullOrWhiteSpace(TPrice.Text) == true)
            {
                MessageBox.Show("Price of book is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            return true;
        }
        public bool isCorrectPublishing()
        {
            if (String.IsNullOrWhiteSpace(TPublishingHouse.Text) == true)
            {
                MessageBox.Show("Publishing house is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            return true;
        }
        public bool isCorrectYear()
        {
            if (String.IsNullOrWhiteSpace(TYear.Text) == true)
            {
                MessageBox.Show("Year of book is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            return true;
        }

        public void clearFields()
        {
            TName.Text = "";
            TAuthor.Text = "";
            TISBN.Text = "";
            TPublishingHouse.Text = "";
            TYear.Text = "";
            TPrice.Text = "";
        }

        private void BLoad_Click(object sender, EventArgs e)
        {
           // WriteRead reader = new WriteRead();
            bool isCorrectLoad = WriteRead.DeSerialize(Books);
            if (isCorrectLoad)
            {
                MessageBox.Show("Load success", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            //WriteRead reader = new WriteRead();
            bool isCorrectSave = WriteRead.Serialize(Books);
            if (isCorrectSave)
            {
                MessageBox.Show("Save success", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void BAddBook_Click(object sender, EventArgs e)
        {
            bool isCorrectText = false;

            if (isCorrectPrice() && isCorrectISBN() && isCorrectAuthor() && isCorrectName() && isCorrectPublishing() && isCorrectYear())
            {
                isCorrectText = true;
            }

            if (isCorrectText == true)
            {
                Book MyBook = new Book();
                MyBook.Name = TName.Text;
                MyBook.Price = double.Parse(TPrice.Text);
                MyBook.Author = TAuthor.Text;
                MyBook.PublishingHouse = TPublishingHouse.Text;
                MyBook.Year = int.Parse(TYear.Text);
                MyBook.ISBN = TISBN.Text;
                Books.Add(MyBook);
                MessageBox.Show("Successfull added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                clearFields();
            }
        }

        private void TPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (number == (int)('.'))
            {
                dotInNumber++;
            }
            if (dotInNumber > 1 && number == (int)('.'))
            {
                e.Handled = true;
            }
            if (!Char.IsDigit(number) && number != 8 && number != (int)('.'))
            {
                e.Handled = true;
            }
        }

        private void TYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void BDisplay_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.RowCount = 1;
            foreach (Book b in Books)
            {
                dataGridView1.RowCount++;
                dataGridView1.Rows[NumberOfBooks].Cells[0].Value = b.Name;
                dataGridView1.Rows[NumberOfBooks].Cells[1].Value = b.Price;
                dataGridView1.Rows[NumberOfBooks].Cells[2].Value = b.Author;
                dataGridView1.Rows[NumberOfBooks].Cells[3].Value = b.PublishingHouse;
                dataGridView1.Rows[NumberOfBooks].Cells[4].Value = b.Year;
                dataGridView1.Rows[NumberOfBooks].Cells[5].Value = b.ISBN;
                dataGridView1.Rows[NumberOfBooks].Cells[6].Value = dataGridView1.RowCount - 1;
                NumberOfBooks++;
            }
            NumberOfBooks = 0;
        }

        private void BDeleteBook_Click(object sender, EventArgs e)
        {
            int numberOfBook = int.Parse(TDeleteNumber.Text) - 1;
            if (numberOfBook < dataGridView1.RowCount - 1 && numberOfBook > 0)
            {
                Books.RemoveAt(numberOfBook);
                MessageBox.Show("Success", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Incorrect number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void BSortName_Click(object sender, EventArgs e)
        {
            Books.Sort(delegate (Book x, Book y)
            {
                if (x.Name == null && y.Name == null) return 0;
                else if (x.Name == null) return -1;
                else if (y.Name == null) return 1;
                else return x.Name.CompareTo(y.Name);
            });
        }

        private void BSortPrice_Click(object sender, EventArgs e)
        {
            Books.Sort(delegate (Book x, Book y)
            {
                if (x.Name == null && y.Name == null) return 0;
                else if (x.Name == null) return -1;
                else if (y.Name == null) return 1;
                else return x.Price.CompareTo(y.Price);
            });
        }

        private void BSortAuthor_Click(object sender, EventArgs e)
        {
            Books.Sort(delegate (Book x, Book y)
            {
                if (x.Name == null && y.Name == null) return 0;
                else if (x.Name == null) return -1;
                else if (y.Name == null) return 1;
                else return x.Author.CompareTo(y.Author);
            });
        }

        private void BSortPublishing_Click(object sender, EventArgs e)
        {
            Books.Sort(delegate (Book x, Book y)
            {
                if (x.Name == null && y.Name == null) return 0;
                else if (x.Name == null) return -1;
                else if (y.Name == null) return 1;
                else return x.PublishingHouse.CompareTo(y.PublishingHouse);
            });
        }

        private void BSortYear_Click(object sender, EventArgs e)
        {
            Books.Sort(delegate (Book x, Book y)
            {
                if (x.Name == null && y.Name == null) return 0;
                else if (x.Name == null) return -1;
                else if (y.Name == null) return 1;
                else return x.Year.CompareTo(y.Year);
            });
        }

        private void BSortISBN_Click(object sender, EventArgs e)
        {
            Books.Sort(delegate (Book x, Book y)
            {
                if (x.Name == null && y.Name == null) return 0;
                else if (x.Name == null) return -1;
                else if (y.Name == null) return 1;
                else return x.ISBN.CompareTo(y.ISBN);
            });
        }

        private void TISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8 && number != (int)('-'))
            {
                e.Handled = true;
            }
        }
    }
}
