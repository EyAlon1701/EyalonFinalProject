﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EyalonFinalProject
{
    public partial class BookForm : Form
    {
        DBConnection dbc = new DBConnection();
        bool isAdd = true;
        int bookID = -1;

        //ADD NEW BOOK
        public BookForm()
        {
            InitializeComponent();
            BtnPages.Enabled = false;
        }

        //UPDATE BOOK
        public BookForm(int bookID, string bookName, int bookYear, string bookOpenPage)
        {
            InitializeComponent();
            this.bookID = bookID;
            TxtBookName.Text = bookName;
            TxtBookYear.Text = bookYear.ToString();
            try
            {
                MemoryStream stream = new MemoryStream(ASCIIEncoding.Default.GetBytes(bookOpenPage));
                RtbOpenPage.LoadFile(stream, RichTextBoxStreamType.RichText);
            }
            catch
            {
                RtbOpenPage.Text = "";
            }
            BtnSumbit.Text = "Update";
            isAdd = false;
        }

        private void BtnSumbit_Click(object sender, EventArgs e)
        {
            if (TxtBookName.Text == "" || TxtBookYear.Text == "")
            {
                MessageBox.Show("You must fill in all fields!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int bookYear = int.Parse(TxtBookYear.Text);

                    if (isAdd)//true - add project book
                    {
                        int num = dbc.AddProjectBook(TxtBookName.Text, bookYear, RtbOpenPage.Rtf);
                        if (num == 1)
                        {
                            this.Close();
                        }
                    }
                    else//false - update project book
                    {
                        dbc.UpdateProjectBook(bookID, TxtBookName.Text, bookYear, RtbOpenPage.Rtf);
                        this.Close();
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("You need to enter a year as an integer", "System message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void BtnPages_Click(object sender, EventArgs e)
        {
            PagesInBookForm pagesInBookForm = new PagesInBookForm(bookID);
            pagesInBookForm.ShowDialog();
        }

        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FontDialog.ShowDialog() == DialogResult.OK)
            {
                RtbOpenPage.SelectionFont = FontDialog.Font;
            }
        }
    }
}

