using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;

namespace MongoDB
{
    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            InitializeComponent();
        }



        private void btnadd_Click(object sender, EventArgs e)
        {
            MongoDB.Driver.MongoClient client = new MongoDB.Driver.MongoClient();
            MongoServer server = client.GetServer();
            //başka makinadaki serverdan veri cekmek icin
            // MongoServer server = new MongoDB.Driver.MongoServer(new MongoDB.Driver.MongoServerSettings() {});

            var db = server.GetDatabase("omur");
            var collection = db.GetCollection<Personel>("Personel");

            collection.Insert(new Personel
                                  {ad = txtad.Text, soyad = txtsoyad.Text, cepno = textcep.Text, sex = cmbsex.Text});



            var data = collection.FindAll().ToList();
            grid.DataSource = data;
            timer1.Start();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtarama_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtarama.Text) && txtarama.Text.Length > 0)
            {
                MongoDB.Driver.MongoClient client = new MongoDB.Driver.MongoClient();
                MongoServer server = client.GetServer();
                //başka makinadaki serverdan veri cekmek icin
                // MongoServer server = new MongoDB.Driver.MongoServer(new MongoDB.Driver.MongoServerSettings() {});

                var db = server.GetDatabase("omur");
                var collection = db.GetCollection<Personel>("Personel");
                var query =
                    Query<Personel>.Where(
                        f =>
                        f.ad == txtarama.Text || f.soyad == txtarama.Text || f.cepno == txtarama.Text ||
                        f.sex == txtarama.Text);


                var data = collection.FindAs<Personel>(query); //tek data cagırmak istiyosan FindAs yerine FindOneAs

                grid.DataSource = data.ToList(); //FindOneAs yaparsan toList e gerek kalmaz
                //collection.save() ile kayıt collection.remove() ile silme
             

            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {

            if (grid.SelectedCells.Count > 0)
            {




                MongoDB.Driver.MongoClient client = new MongoDB.Driver.MongoClient();
                MongoServer server = client.GetServer();



                var db = server.GetDatabase("omur");
                var collection = db.GetCollection("Personel");

                var id = ObjectId.Parse(grid.CurrentRow.Cells[0].Value.ToString());
                var query = Query<Personel>.EQ(p => p.Id, id);
                collection.Remove(query);

                timer1.Start();




            }

        }

            private void timer1_Tick  (object sender, EventArgs e)
            {
                if (progressBar1.Value < 100)
                {
                    progressBar1.Value += 10;
                }
                
            }


       

        private void btnall_Click(object sender, EventArgs e)
        {
            var server = MongoServer.Create();
           
            var db = server.GetDatabase("omur");
            
            MongoCollection<Personel> coll = db.GetCollection<Personel>("Personel");
            var res = coll.FindAll();

            List<Personel> resultList = res.ToList<Personel>();
            grid.DataSource = resultList;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (grid.SelectedRows.Count == 1)
            {
                txtad.Text = grid.SelectedRows[0].Cells["ad"].Value.ToString();
                txtsoyad.Text = grid.SelectedRows[0].Cells["soyad"].Value.ToString();
                textcep.Text = grid.SelectedRows[0].Cells["cepno"].Value.ToString();
                cmbsex.Text = grid.SelectedRows[0].Cells["sex"].Value.ToString();

                

            } 
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            MongoDB.Driver.MongoClient client = new MongoDB.Driver.MongoClient();
            MongoServer server = client.GetServer();



            var db = server.GetDatabase("omur");
            var collection = db.GetCollection("Personel");
            var id = ObjectId.Parse(grid.CurrentRow.Cells[0].Value.ToString());
            var query = Query<Personel>.EQ(p => p.Id, id);
            var update = Update<Personel>.
     Set(p => p.ad, txtad.Text).
     Set(p => p.soyad, txtsoyad.Text)
     .Set(p=> p.cepno, textcep.Text)
     .Set(p=> p.sex, cmbsex.Text);

            collection.Update(query, update);

        }
        }
    }

