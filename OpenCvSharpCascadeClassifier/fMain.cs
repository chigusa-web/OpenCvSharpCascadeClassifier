using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenCvSharpCascadeClassifier
{
    public partial class fMain : Form
    {

        // カスケードファイルの保存ディレクトリ
#if DEBUG
        string dirCascades = @"..\..\..\cascades\";
#else 
        string dirCascades = @".\cascades\";
#endif

        // カスケードファイルのパスリスト
        List<string> cascadePaths = new List<string>();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public fMain()
        {
            InitializeComponent();

            // ドロップを許可
            pbSrc.AllowDrop = true;

            // カスケードファイルの読み込み
            ReadCascadesFile();
        }

        /// <summary>
        /// カスケードファイルの読み込み
        /// </summary>
        private void ReadCascadesFile()
        {
            // ファイル一覧を取得する
            string[] files = System.IO.Directory.GetFiles(dirCascades, "*.xml", System.IO.SearchOption.AllDirectories);

            foreach (string filePath in files)
            {
                // ファイル名を分解
                string fileName = Path.GetFileName(filePath);

                // コンボボックスに追加
                cbCascades.Items.Add(fileName);

                // ファイルパスを保持
                cascadePaths.Add(filePath);
            }

            if (cbCascades.Items.Count > 0)
            {
                // 一件目を選択
                cbCascades.SelectedIndex = 0;
            }

        }

        /// <summary>
        /// PictureBox ドラッグイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbSrc_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        /// <summary>
        /// PictureBox ドロップイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbSrc_DragDrop(object sender, DragEventArgs e)
        {
            // ドラッグされたファイルのパスを取得
            string[] fileName = (string[])e.Data.GetData(DataFormats.FileDrop);

            // 画像を表示
            pbSrc.ImageLocation = fileName[0];

        }

        /// <summary>
        /// 画像読み込み完了イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbSrc_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            // 物体検出
            Detect();
        }

        /// <summary>
        /// 物体検出
        /// </summary>
        private void Detect()
        {

            // 画像が未読み込み、または、画像が無効な場合は処理なし
            if (pbSrc.Image == null || pbSrc.Image == pbSrc.ErrorImage)
            {
                return;
            }

            // カスケードファイルの選択有無
            if (cbCascades.SelectedIndex <= -1)
            {
                return;
            }

            // カスケードファイルパスを取得
            string cascadePath = cascadePaths[cbCascades.SelectedIndex];

            // PictureBoxの画像をBitmapで取得
            using (var bmp = new Bitmap(pbSrc.Image))
            // BitmapをMatに変換
            using (var mat = OpenCvSharp.Extensions.BitmapConverter.ToMat(bmp))
            // カスケード分類器の読み込み
            using (var cascade = new CascadeClassifier(cascadePath))
            {
                // 検出
                foreach (Rect rectDetect in cascade.DetectMultiScale(mat))
                {
                    // 顔に枠を表示
                    Rect rect = new Rect(rectDetect.X, rectDetect.Y, rectDetect.Width, rectDetect.Height);
                    Cv2.Rectangle(mat, rect, new OpenCvSharp.Scalar(255, 255, 0), 2);
                }

                // 画像を表示
                pbOutput.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(mat.CvtColor(ColorConversionCodes.BGRA2BGR));
            }
        }

    }
}
