using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_MVP
{
    class Presenter
    {
        private readonly Model model;
        private readonly MainWindow view;
        int s;

        public Presenter(MainWindow v)
        {
            model = new Model();
            view = v;
            view.Equal += view_Equal;
            
        }

        void view_Equal(object sender, EventArgs e)
        {
            model.label1 = Convert.ToString(view.label1.Content);
            
            int k = Convert.ToInt32(view.textBox1.Text);
            int t = Convert.ToInt32(view.textBox2.Text);
            view.textBox3.Text = model.Equal(k,t).ToString();
            view.label2.Content = "=".ToString();
        }

       
    }
}
