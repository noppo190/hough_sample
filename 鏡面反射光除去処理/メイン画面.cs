using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenCvSharp;

namespace Hough変換テスト
{
    public partial class メイン画面 : Form
    {
        public static IplImage 入力画像;//3ch
        public static IplImage Canny;//1ch
        public static IplImage Close;//1ch
        public static IplImage Hough;//3ch
        public static IplImage 出力画像;//3ch
        public static Boolean 準備OK=false;
        public static CvSeq 直線;
        public メイン画面()
        {
            InitializeComponent();
        }
        


        private void OnClick開く(object sender, EventArgs e)
        {
            if (入力画像 != null)入力画像.Dispose();
            if (出力画像 != null)出力画像.Dispose();
            if (Canny != null) Canny.Dispose();
            if (Close != null) Close.Dispose();
            if (Hough != null) Hough.Dispose();
            if(直線!=null)直線.Dispose();
            OpenFileDialog dialog = new OpenFileDialog()
            {
                Multiselect = true,  // 複数選択の可否
                Filter =  // フィルタ
                "画像ファイル|*.bmp;*.gif;*.jpg;*.png|全てのファイル|*.*",
            };
            //ダイアログを表示
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                int a = 0;
                //OKボタンがクリックされたとき
                //選択されたファイル名をすべて表示する
                foreach (var file in dialog.FileNames.Select((value, index) => new { value, index }))
                {
                    入力画像 = new IplImage(file.value, LoadMode.Color);
                }
                // ファイル名をタイトルバーに設定
                this.Text = dialog.FileNames[0];

                pictureBoxIpl1.Size = pictureBoxIplのサイズ調整(入力画像);
                pictureBoxIpl1.ImageIpl = 入力画像;
            }
        }

        public static System.Drawing.Size pictureBoxIplのサイズ調整(IplImage sample)
        {
            return new System.Drawing.Size(sample.Width, sample.Height);
        }

        private void TextChanged_x(object sender, EventArgs e)
        {
            カーソル移動操作();
        }

        private void TextChanged_y(object sender, EventArgs e)
        {
            カーソル移動操作();
        }
        private void カーソル移動操作()
        {
            if (pictureBoxIpl1.ImageIpl != null)
            {
                double isnumber_x, isnumber_y;
                if (double.TryParse(textBox_x.Text, out isnumber_x) && double.TryParse(textBox_y.Text, out isnumber_y))
                    if ((isnumber_x >= 0 && isnumber_x <= pictureBoxIpl1.ImageIpl.Width) && (isnumber_y >= 0 && isnumber_y <= pictureBoxIpl1.ImageIpl.Height))
                    {
                        //CvColor c = pictureBoxIpl1.ImageIpl[(int)isnumber_y, (int)isnumber_x];
                        //label_color.Text = "" + c.B;
                        label_color.Text = (Cv.Get2D(pictureBoxIpl1.ImageIpl, (int)isnumber_y, (int)isnumber_x)).ToString();
                        //クライアント座標を画面座標に変換する
                        System.Drawing.Point mp = this.PointToScreen(new System.Drawing.Point((int)isnumber_x + pictureBoxIpl1.Location.X, (int)isnumber_y + pictureBoxIpl1.Location.Y));
                        //マウスポインタの位置を設定する
                        System.Windows.Forms.Cursor.Position = mp;
                    }
            }
        }

        private void MouseMove_pictureBoxIpl1(object sender, MouseEventArgs e)
        {
            System.Drawing.Point sp = System.Windows.Forms.Cursor.Position;
            System.Drawing.Point cp = this.PointToClient(sp);
            label_座標.Text = "(" + (cp.X - pictureBoxIpl1.Location.X) + "," + (cp.Y - pictureBoxIpl1.Location.Y) + ")";
        }

        private void OnClick_pictureBoxIpl1(object sender, MouseEventArgs e)
        {
            if (pictureBoxIpl1.ImageIpl != null)
            {
                System.Drawing.Point sp = System.Windows.Forms.Cursor.Position;
                System.Drawing.Point cp = this.PointToClient(sp);

                label_color.Text = (Cv.Get2D(pictureBoxIpl1.ImageIpl, cp.Y - pictureBoxIpl1.Location.Y, cp.X - pictureBoxIpl1.Location.X)).ToString();
                textBox_x.Text = "" + (cp.X - pictureBoxIpl1.Location.X);
                textBox_y.Text = "" + (cp.Y - pictureBoxIpl1.Location.Y);
            }
        }


        private void OnClick保存(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory(@"result");//resultフォルダの作成
            SaveFileDialog sfd = new SaveFileDialog();//SaveFileDialogクラスのインスタンスを作成
            sfd.FileName = "image";//はじめのファイル名を指定する
            sfd.InitialDirectory = @"result\";//はじめに表示されるフォルダを指定する
            sfd.Filter ="画像ファイル|*.bmp;*.gif;*.jpg;*.png|全てのファイル|*.*";//[ファイルの種類]に表示される選択肢を指定する
            sfd.FilterIndex = 1;//[ファイルの種類]ではじめに「画像ファイル」が選択されているようにする
            sfd.Title = "保存先のファイルを選択してください";//タイトルを設定する
            sfd.RestoreDirectory = true;//ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
            sfd.OverwritePrompt = true;//既に存在するファイル名を指定したとき警告する．デフォルトでTrueなので指定する必要はない
            sfd.CheckPathExists = true;//存在しないパスが指定されたとき警告を表示する．デフォルトでTrueなので指定する必要はない

            //ダイアログを表示する
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //OKボタンがクリックされたとき
                //選択されたファイル名を表示する
                Console.WriteLine(sfd.FileName);
                pictureBoxIpl1.ImageIpl.SaveImage(sfd.FileName);
            }
        }
        private void OnClick実行(object sender, EventArgs e)
        {
            Console.WriteLine("OnClick実行　開始");
            Canny = Canny法(入力画像);
            Close =クロージング(Canny);
            Hough変換で直線を検出();
            画像を表示(Hough);
            Console.WriteLine("OnClick実行　終了");
        }
        private void OnScroll_trackBar_Closing(object sender, EventArgs e)
        {
            if (Canny!=null)
            {
                Close = クロージング(Canny);
                画像を表示(Close);
            }
        }

        private void OnScroll_canny2(object sender, EventArgs e)
        {
            if (入力画像!=null)
            {
                Canny = Canny法(入力画像);
                画像を表示(Canny);
            }
        }

        private void OnScroll_canny1(object sender, EventArgs e)
        {
            if (入力画像 != null)
            {
                Canny = Canny法(入力画像);
                画像を表示(Canny);
            }
        }
        private IplImage Canny法(IplImage src)
        {
            IplImage src_gray = Cv.CreateImage(new CvSize(src.Width,src.Height),src.Depth,1);
            IplImage dst = Cv.CreateImage(new CvSize(src.Width,src.Height),src.Depth,1);
            Cv.CvtColor(src,src_gray,ColorConversion.BgrToGray);
            if (src.NChannels != 1) Cv.CvtColor(src, src_gray, ColorConversion.BgrToGray);
            else src_gray = src.Clone();

            Cv.Canny(src_gray, dst, trackBar_canny1.Value, trackBar_canny2.Value);
            src_gray.Dispose();
            return dst;
 
        }

        private IplImage クロージング(IplImage src)
        {
            IplImage dst = Cv.CreateImage(new CvSize(src.Width, src.Height), src.Depth, 1);
            IplImage tmp = Cv.CreateImage(new CvSize(src.Width, src.Height), src.Depth, 1);
            IplImage src_gray = Cv.CreateImage(new CvSize(src.Width, src.Height), src.Depth, 1);
            if (src.NChannels != 1) Cv.CvtColor(src, src_gray, ColorConversion.BgrToGray);
            else src_gray = src.Clone();
            
            IplConvKernel element = Cv.CreateStructuringElementEx(3, 3, 1, 1, ElementShape.Rect, null);


            if (trackBar_Closing.Value != 0) Cv.MorphologyEx(src_gray, dst, tmp, element, MorphologyOperation.Close, trackBar_Closing.Value);
            else dst = src_gray.Clone();
            src_gray.Dispose();
            tmp.Dispose();
            return dst;
        }
        private void 画像を表示(IplImage src)
        {
            if (出力画像 != null) 出力画像.Dispose();
            IplImage dst=Cv.CreateImage(new CvSize(src.Width, src.Height), src.Depth, 3);
            if (src.NChannels == 1) Cv.CvtColor(src, dst, ColorConversion.GrayToBgr);
            else dst = src.Clone();
            出力画像 = dst.Clone();
            pictureBoxIpl1.ImageIpl = 出力画像;
            dst.Dispose();
        }
        private void Hough変換で直線を検出()
        {
            if (直線 != null) 直線.Dispose();
            Hough = 入力画像.Clone();
            CvMemStorage storage = new CvMemStorage();
            直線 = Cv.HoughLines2(Close, storage, HoughLinesMethod.Probabilistic, trackBar_rho.Value, Math.PI / 180.0, trackBar_threshold.Value, trackBar_param1.Value, trackBar_param2.Value);
            for (int i = 0; i < 直線.Total; i++)
            {
                CvLineSegmentPoint elem = 直線.GetSeqElem<CvLineSegmentPoint>(i).Value;
                Hough.Line(elem.P1, elem.P2, CvColor.Red, 1, LineType.AntiAlias, 0);
            }
            storage.Dispose();
 
        }

        private void trackBar1_rho_Scroll(object sender, EventArgs e)
        {
            テキストボックスの値を更新();
            if (Close != null)
            {
                Hough変換で直線を検出();
                画像を表示(Hough);
            }
        }

        private void trackBar_threshold_Scroll(object sender, EventArgs e)
        {
            テキストボックスの値を更新();
            if (Close != null)
            {
                Hough変換で直線を検出();
                画像を表示(Hough);
            }
        }


        private void trackBar_param1_Scroll(object sender, EventArgs e)
        {
            テキストボックスの値を更新();
            if (Close != null)
            {
                
                Hough変換で直線を検出();
                画像を表示(Hough);
            }
        }

        private void trackBar_param2_Scroll(object sender, EventArgs e)
        {
            テキストボックスの値を更新();
            if (Close != null)
            {
                Hough変換で直線を検出();
                画像を表示(Hough);
            }
        }
        private void テキストボックスの値を更新()
        {
            textBox_threshold.Text = trackBar_threshold.Value.ToString();
            textBox_rho.Text = trackBar_rho.Value.ToString();
            textBox_param2.Text = trackBar_param2.Value.ToString();
            textBox_param1.Text = trackBar_param1.Value.ToString();
 
        }

        private void OnTextChanged_rho(object sender, EventArgs e)
        {
            トラックバーの値を更新();
            Hough変換で直線を検出();
            画像を表示(Hough);
        }

        private void OnTextChanged_threshold(object sender, EventArgs e)
        {
            トラックバーの値を更新();
            Hough変換で直線を検出();
            画像を表示(Hough);
        }

        private void OnTextChanged_param1(object sender, EventArgs e)
        {
            トラックバーの値を更新();
            Hough変換で直線を検出();
            画像を表示(Hough);
        }

        private void OnTextChanged_param2(object sender, EventArgs e)
        {
            トラックバーの値を更新();
            Hough変換で直線を検出();
            画像を表示(Hough);
        }

        private void トラックバーの値を更新()
        {
             if(textBox_rho.Text!=""&&int.Parse(textBox_rho.Text) >= trackBar_rho.Minimum && int.Parse(textBox_rho.Text)<=trackBar_rho.Maximum)
                trackBar_rho.Value = int.Parse(textBox_rho.Text);
             if (textBox_threshold.Text != "" && int.Parse(textBox_threshold.Text) >= trackBar_threshold.Minimum && int.Parse(textBox_threshold.Text) <= trackBar_threshold.Maximum)
                 trackBar_threshold.Value = int.Parse(textBox_threshold.Text);
             if (textBox_param1.Text != "" && int.Parse(textBox_param1.Text) >= trackBar_param1.Minimum && int.Parse(textBox_param1.Text) <= trackBar_param1.Maximum)
                 trackBar_param1.Value = int.Parse(textBox_param1.Text);
             if (textBox_param2.Text != "" && int.Parse(textBox_param2.Text) >= trackBar_param2.Minimum && int.Parse(textBox_param2.Text) <= trackBar_param2.Maximum)
                 trackBar_param2.Value = int.Parse(textBox_param2.Text);
        }

    }
}
