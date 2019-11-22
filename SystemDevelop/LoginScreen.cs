using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemDevelop.Model;


namespace SystemDevelop
{
    public partial class LoginScreen : Form
    {

        private HomeScreen homeScreen;
        private Login login;
        public LoginScreen()
        {
            InitializeComponent();
            homeScreen = new HomeScreen(this);
            login = new Login(homeScreen,this);
        }
        
        private void LoginScreen_Load(object sender, EventArgs e)
        {
            //タブを左側に表示する
            menuControl.Alignment = TabAlignment.Left;

            //TabControlをオーナードローする
            menuControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            //DrawItemイベントハンドラを追加
            menuControl.DrawItem += new DrawItemEventHandler(TabControl1_DrawItem);
            for (int i = 1; menuControl.TabPages.Count >= i; i++)
            {
                menuControl.TabPages.Remove(menuControl.TabPages[i]);
            }
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            login.AuthUser(idTextBox.Text, passTextBox.Text);
        }
       
        private void LoginScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                login.AuthUser(idTextBox.Text, passTextBox.Text);
            }
        }

        private void idTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login.AuthUser(idTextBox.Text, passTextBox.Text);
            }
        }

        private void passWordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login.AuthUser(idTextBox.Text, passTextBox.Text);
            }
        }

        private void TabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            //対象のTabControlを取得
            TabControl tab = (TabControl)sender;
            TabPage page = tab.TabPages[e.Index];
            //タブページのテキストを取得
            string txt = page.Text;

            //StringFormatを作成
            StringFormat sf = new StringFormat();
            //水平垂直方向の中央に、行が完全に表示されるようにする
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;
            sf.FormatFlags |= StringFormatFlags.LineLimit;

            //タブのテキストと背景を描画するためのブラシを決定する
            Brush foreBrush, backBrush;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                //選択されているタブのテキストを赤、背景を青とする
                foreBrush = Brushes.Black;
                backBrush = Brushes.LightBlue;
            }
            else
            {
                //選択されていないタブのテキストは灰色、背景を白とする
                foreBrush = Brushes.Gray;
                backBrush = Brushes.White;
            }
            e.Graphics.FillRectangle(backBrush, e.Bounds);
            e.Graphics.DrawString(txt, page.Font, foreBrush, e.Bounds, sf);
        }
    }
}
