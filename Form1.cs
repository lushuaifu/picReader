using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace pictReader
{
    public partial class Form1 : Form
    {
	//private Bitmap fbt = null;  //原始图片
	private int n = 0;  //放大缩小倍数
	private bool isFD = true;//上次操作是否是放大
	private string nowFilePath = "";    //普通模式当前文件路径
	private bool isHDP = false;//是否是放灯片模式
	public Form1()
	{
	    InitializeComponent();
	}
	//随机生成字母
	private static char[] constant =
       {
	    '0','1','2','3','4','5','6','7','8','9',
	    'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',
	    'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'
       };
	public static string GenerateRandom(int Length)
	{
	    System.Text.StringBuilder newRandom = new System.Text.StringBuilder(52);
	    Random rd = new Random();
	    for (int i = 0; i < Length; i++)
	    {
		newRandom.Append(constant[rd.Next(52)]);
	    }
	    return newRandom.ToString();
	}
	
	//获得文件夹内所有文件名
	private static void getDirectory(StreamWriter sw,string path)
	{
	    DirectoryInfo root = new DirectoryInfo(path);
	    foreach(FileInfo f in root.GetFiles())
	    {
		sw.WriteLine(f.Name);
	    }
	    sw.Close();
	}
	public static void write2txt(string path)
	{

	    StreamWriter sw = new StreamWriter(new FileStream("filelist.txt", FileMode.Create));
	    getDirectory(sw, path);
	}
	//txt写入listbox
	private void Write2Listbox(ListBox lst,string path)
	{
	    StreamReader sr = null;
	    sr = new StreamReader(path, System.Text.Encoding.Default);
	    string line;
	    while ((line = sr.ReadLine()) != null)
	    {
		lst.Items.Add(line);
	    }
	    sr.Close();
	}


	//图像放大
	private void fd(Bitmap img)
	{
	    if (!isFD)
	    {
		this.n += 2;
	    }
	    this.isFD = true;
	    if (this.pictureBox1.Image != null)
	    {
		int width = img.Width;
		int height = img.Height;

		Bitmap bt;
		if(n>0)
		{
		    if(n<30)
		    {
			bt = new Bitmap(img, (int)(width * (1 + this.n * 0.1)), (int)(height * (1 + this.n * 0.1)));
			this.pictureBox1.Image = bt;
		    }
		    else
		    {
			bt = new Bitmap(img, (int)(width * (1 + 30 * 0.1)), (int)(height * (1 + 30 * 0.1)));
			this.pictureBox1.Image = bt;
		    }

		}

		this.n++;
	    }
	}
	//图像缩小
	private void sx(Bitmap img)
	{
	    if (isFD)
	    {
		this.n -= 2;
	    }
	    this.isFD = false;
	    if (this.pictureBox1.Image != null)
	    {
		int width = img.Width;
		int height = img.Height;
		Bitmap bt;
		if (0 > n )
		{
		    if (n > -10) 
		    {
			bt = new Bitmap(img, (int)(width * (1 + this.n * 0.1)), (int)(height * (1 + this.n * 0.1)));
			this.pictureBox1.Image = bt;
		    }else
		    {
			bt = new Bitmap(img, (int)(width * (1 - 10 * 0.1)), (int)(height * (1 - 10 * 0.1)));
			this.pictureBox1.Image = bt;
		    }
		}
		
		
		this.n--;
	    }
	}
	private void button1_Click(object sender, EventArgs e)
	{
	    
	}

	private void pictureBox1_MouseEnter(object sender, EventArgs e)
	{
	    this.pictureBox1.Focus();
	}

	protected void pictureBox1_MouseWeel(object sender, MouseEventArgs e)
	{
	    Image img = pictureBox1.Image;
	    Bitmap bmp = new Bitmap(img);
	    if (!this.isHDP)
	    {
		//鼠标向上滚
		if (e.Delta == 120)
		{
		    this.fd(bmp);
		}
		else if (e.Delta == -120)//鼠标向下滚
		{
		    this.sx(bmp);
		}
	    }
	}

	private void button3_Click(object sender, EventArgs e)
	{
	    OpenFileDialog ofd = new OpenFileDialog();
	    ofd.InitialDirectory = tbInputFolder.Text;
	    ofd.Filter = "照片|*.jpg;*.png;*.ico;*.bmp;*.tiff;*.tif";
	    ofd.Title = "打开文件";
	    DialogResult dr = ofd.ShowDialog();
	    if(dr == DialogResult.OK)
	    {
		this.pictureBox1.ImageLocation = ofd.FileName;
		this.Text = ofd.FileName;
		this.nowFilePath = ofd.FileName;
		tbInputFolder.Text = System.IO.Path.GetDirectoryName(ofd.FileName);
	    }
	}

	private void button1_Click_1(object sender, EventArgs e)
	{
	    if (this.pictureBox1.Image!=null)
	    {
		DirectoryInfo di = new DirectoryInfo(Path.GetDirectoryName(this.nowFilePath));
		FileInfo[] files1 = di.GetFiles("*.jpg");
		FileInfo[] files2 = di.GetFiles("*.png");
		FileInfo[] files3 = di.GetFiles("*.bmp");
		FileInfo[] files4 = di.GetFiles("*.ico");
        FileInfo[] files5 = di.GetFiles("*.tiff");
        FileInfo[] files = new FileInfo[files1.Length + files2.Length + files3.Length + files4.Length + files5.Length];
		files1.CopyTo(files, 0);
		files2.CopyTo(files, files1.Length);
		files3.CopyTo(files, files1.Length + files2.Length);
		files4.CopyTo(files, files1.Length + files2.Length + files3.Length);
        files5.CopyTo(files, files1.Length + files2.Length + files3.Length + files4.Length);
        int i = 0;
		foreach (FileInfo fi in files)
		{
		    if (fi.Name == Path.GetFileName(this.nowFilePath))
			break;
		    i++;
		}
		this.nowFilePath = i == 0 ? files[files.Length - 1].FullName : files[i - 1].FullName;
		this.Text = i == 0 ? Path.GetDirectoryName(this.nowFilePath) + "\\" + files[files.Length - 1] : Path.GetDirectoryName(this.nowFilePath) + "\\" + files[i - 1] ;
		this.pictureBox1.ImageLocation = this.nowFilePath;
	    }
	}

	private void button2_Click(object sender, EventArgs e)
	{
	    if (this.pictureBox1.Image != null)
	    {
		DirectoryInfo di = new DirectoryInfo(Path.GetDirectoryName(this.nowFilePath));
		FileInfo[] files1 = di.GetFiles("*.jpg");
		FileInfo[] files2 = di.GetFiles("*.png");
		FileInfo[] files3 = di.GetFiles("*.bmp");
		FileInfo[] files4 = di.GetFiles("*.ico");
        FileInfo[] files5 = di.GetFiles("*.tiff");
        FileInfo[] files = new FileInfo[files1.Length + files2.Length + files3.Length + files4.Length + files5.Length];
		files1.CopyTo(files, 0);
		files2.CopyTo(files, files1.Length);
		files3.CopyTo(files, files1.Length + files2.Length);
		files4.CopyTo(files, files1.Length + files2.Length + files3.Length);
        files5.CopyTo(files, files1.Length + files2.Length + files3.Length + files4.Length);
		int i = 0;
		foreach (FileInfo fi in files)
		{
		    if (fi.Name == Path.GetFileName(this.nowFilePath))
			break;
		    i++;
		}
		this.nowFilePath = i == (files.Length - 1) ? files[0].FullName : files[i + 1].FullName;
		this.Text = i == (files.Length - 1) ? Path.GetDirectoryName(this.nowFilePath) + "\\" + files[0]  : Path.GetDirectoryName(this.nowFilePath) + "\\" + files[i + 1] ;
		this.pictureBox1.ImageLocation = this.nowFilePath;
	    }
	}

	private void tbImageFoder_TextChanged(object sender, EventArgs e)
	{

	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{

	}

	private void button4_Click(object sender, EventArgs e)
	{
            //   FolderBrowserDialog dlg = new FolderBrowserDialog();
            //   dlg.SelectedPath = SaveFolder.Text;
            //   if (dlg.ShowDialog() != DialogResult.OK) return;

            //   foreach (Control ctrl in pictureBox1.Controls)
            //   {
            //PictureBox pb = (PictureBox)ctrl;
            //if (pb.Image != null)
            //{
            //    this.pictureBox1.Image.Save( "D:\\"+GenerateRandom(8)+".jpg");
            //}
            //   }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "照片|*.jpg;*.png;*.bmp;*.ico";
            sfd.FileName = SaveFolder.Text + "\\" + GenerateRandom(8);
            sfd.DefaultExt = "jpg";
            sfd.AddExtension = true;
            DialogResult dr = sfd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                if (this.pictureBox1.Image != null)
                {
                    this.pictureBox1.Image.Save(sfd.FileName);
                    this.Text = sfd.FileName;
                    this.nowFilePath = sfd.FileName;
                    SaveFolder.Text = System.IO.Path.GetDirectoryName(sfd.FileName);
                }
            }
        }

	private void 放大button_Click(object sender, EventArgs e)
	{
	    Image img = pictureBox1.Image;
	    Bitmap bmp = new Bitmap(img);
	    this.fd(bmp);
	}

	private void 缩小button_Click(object sender, EventArgs e)
	{
	    Image img = pictureBox1.Image;
	    Bitmap bmp = new Bitmap(img);
	    this.sx(bmp);
	}

	private void checkBox1_CheckedChanged(object sender, EventArgs e)
	{
	  
	}

	private void listBox_SelectedIndexChanged(object sender, EventArgs e)
	{
	    string str = listBox.SelectedItem.ToString();
        string filename = tbInputFolder.Text + "\\" + str;
        this.Text = filename;
	    pictureBox1.ImageLocation = filename;
        
	}

	private void AllFilesbutton_Click(object sender, EventArgs e)
	{
	    listBox.Items.Clear();
	    string path = tbInputFolder.Text;
	    write2txt(path);
	    string name = "filelist.txt";
	    Write2Listbox(listBox, name);
	}

	private void Write2list_Click(object sender, EventArgs e)
	{
	    listBox.Items.Clear();
	    string name = "E:\\demo#\\pictReader\\pictReader\\bin\\x64\\Release\\filelist.txt";
	    Write2Listbox(listBox, name);
	}

	private void radioButton1_CheckedChanged(object sender, EventArgs e)
	{

	}

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
