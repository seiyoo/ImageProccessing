using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ImageProccessing
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            DefineEventHandler();

            var initImage = new Bitmap(Properties.Resources.Lena);
            _originalImage = initImage;
            DisplayedImage = initImage;
        }

        private void DefineEventHandler()
        {
            #region 画像処理関係
            // 各リセットボタンに元画像表示イベントを割り当て
            var resetButtons = new List<Button>
            {
                btnResetThres,
                btnResetAlpha,
                btnResetGray,
                btnResetContrast,
                btnResetGamma
            };
            resetButtons.ForEach(btn => 
            {
                btn.Click += (_, e) => { DisplayedImage = _originalImage; };
            });

            //TrackBarとNumericUpDownの値を同期させる
            Action<TrackBar, NumericUpDown> BindUI = (trb, nud) =>
            {
                trb.ValueChanged += (_, e) => { nud.Value = trb.Value; };
                nud.ValueChanged += (_, e) => { trb.Value = (int)nud.Value; };
            };
            BindUI(trbThres, nudThres);
            BindUI(trbAlpha, nudAlpha);
            BindUI(trbContrast, nudContrast);

            // 2値化
            nudThres.ValueChanged += (_, e) =>
            {
                var value = (byte)nudThres.Value;

                DisplayedImage = _originalImage.Thresholding(value);
            };

            // アルファチャンネル
            nudAlpha.ValueChanged += (_, e) =>
            {
                var value = (byte)nudAlpha.Value;

                DisplayedImage = _originalImage.AlphaChannel(value);
            };

            // グレースケール
            var grayButtons = new List<Button>
            {
                btnGrayR, btnGrayG, btnGrayB,btnGrayC, btnGrayM, btnGrayY
            };
            grayButtons.ForEach(btn =>
            {
                btn.Click += (sender, e) => 
                {
                    var btnGray = sender as Button;
                    switch (btnGray.Name)
                    {
                        case "btnGrayR":
                            DisplayedImage = _originalImage.GrayScale(GrayScaleFilter.R);
                            break;
                        case "btnGrayG":
                            DisplayedImage = _originalImage.GrayScale(GrayScaleFilter.G);
                            break;
                        case "btnGrayB":
                            DisplayedImage = _originalImage.GrayScale(GrayScaleFilter.B);
                            break;
                        case "btnGrayC":
                            DisplayedImage = _originalImage.GrayScale(GrayScaleFilter.C);
                            break;
                        case "btnGrayM":
                            DisplayedImage = _originalImage.GrayScale(GrayScaleFilter.M);
                            break;
                        case "btnGrayY":
                            DisplayedImage = _originalImage.GrayScale(GrayScaleFilter.Y);
                            break;
                    }
                };
            });

            // コントラスト
            Action Contrast = () =>
            {
                decimal amount = nudContrastAmount.Value;
                var threshold = (byte)nudContrast.Value;
                DisplayedImage = _originalImage.Contrast(amount, threshold);
            };
            nudContrast.ValueChanged += (_, e) =>{ Contrast(); };
            nudContrastAmount.ValueChanged += (_, e) =>{ Contrast(); };

            // ガンマ補正
            Action GammaCorrection = () =>
            {
                var min = (byte)nudGammaMin.Value;
                var max = (byte)nudGammaMax.Value;
                decimal gamma = nudGamma.Value;

                // 最小値・最大値の整合性確認
                if (min >= max)
                {
                    nudGammaMin.Value = max - 1;
                }

                if (min == max)
                {
                    return;
                }

                // 逆ガンマ判定
                if (chbDegamma.Checked == true) gamma = 1 / gamma;

                DisplayedImage = _originalImage.GammaCorrection(min, max ,gamma);
            };
            nudGammaMin.ValueChanged += (_, e) => { GammaCorrection();};
            nudGammaMax.ValueChanged += (_, e) => { GammaCorrection();};
            nudGamma.ValueChanged += (_, e) => { GammaCorrection();};
            chbDegamma.CheckedChanged += (_, e) => { GammaCorrection(); };
            #endregion

            #region メニューバー関係
            mnuOpen.Click += (_, e) =>
            {
                ofdImage.Filter = 
                "Image File(*.bmp,*.jpg,*.png)|*.bmp;*.jpg;*.png;|Jpeg(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp|PNG(*.png)|*.png";
                if (ofdImage.ShowDialog() == DialogResult.OK)
                {
                    var bmp = GetBitmapFromFilename(ofdImage.FileName);
                    _originalImage = bmp;
                    DisplayedImage = bmp;
                }
            };
            mnuSave.Click += (_, e) =>
            {
                sfdImage.Filter = "PNG(*.png)|*.png|Jpeg(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp|Gif(*.gif)|*.gif";
                sfdImage.FileName = "Result";
                if (sfdImage.ShowDialog() == DialogResult.OK)
                {
                    // 拡張子の確認および小文字化
                    string ext = System.IO.Path.GetExtension(sfdImage.FileName).ToLower();
                    // 指定拡張子に対応する画像保存フォーマット
                    switch (ext)
                    {
                        case ".jpg":
                            DisplayedImage.Save(sfdImage.FileName, ImageFormat.Jpeg);
                            break;
                        case ".bmp":
                            DisplayedImage.Save(sfdImage.FileName, ImageFormat.Bmp);
                            break;
                        case ".png":
                            DisplayedImage.Save(sfdImage.FileName, ImageFormat.Png);
                            break;
                        case ".gif":
                            DisplayedImage.Save(sfdImage.FileName, ImageFormat.Gif);
                            break;
                    }
                }
            };
            mnuLena.Click += (_, e) =>
            {
                var lena = new Bitmap(Properties.Resources.Lena);
                _originalImage = lena;
                DisplayedImage = lena;
            };
            mnuClose.Click += (_, e) => { this.Close(); };

            // PictureBoxSizeModeをメニューストリップに追加する
            foreach (PictureBoxSizeMode sizeMode in Enum.GetValues(typeof(PictureBoxSizeMode)))
            {
                var tsmItem = new ToolStripMenuItem();
                tsmItem.Text = sizeMode.ToString();
                // 1項目のみ選択されるようにする
                tsmItem.Click += (sender, e) =>
                {
                    foreach (ToolStripMenuItem item in tsmSizeMode.DropDownItems)
                    {
                        if (object.ReferenceEquals(item, sender))
                        {
                            item.CheckState = CheckState.Indeterminate;
                        }
                        else
                        {
                            item.CheckState = CheckState.Unchecked;
                        }
                    }
                };
                // PictureBoxを選択項目と同じSizeModeにする
                tsmItem.CheckedChanged += (sender, e) =>
                {
                    if (tsmItem.CheckState == CheckState.Indeterminate)
                    {
                        pcbMain.SizeMode = sizeMode;
                    }
                };

                // "CenterImage"をデフォルトのサイズモードとする
                if (tsmItem.Text == PictureBoxSizeMode.CenterImage.ToString())
                {
                    tsmItem.CheckState = CheckState.Indeterminate;
                }

                tsmSizeMode.DropDownItems.Add(tsmItem);
            }

            #endregion

            #region PictureBox関連
            pcbMain.AllowDrop = true;
            pcbMain.DragEnter += (_, e) =>
            {
                // ファイル以外のドラッグは受け付けない
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                    e.Effect = DragDropEffects.All;
                else
                    e.Effect = DragDropEffects.None;
            };
            pcbMain.DragDrop += (_, e) =>
            {
                // ドラッグファイル名を取得
                string fileName = GetFileNameToDragEvent(e);
                if (fileName != null)
                {
                    var bmp = GetBitmapFromFilename(fileName);
                    _originalImage = bmp;
                    DisplayedImage = bmp;
                }
            };
            #endregion
        }

        /// <summary>
        /// 元画像を保持
        /// </summary>
        private Bitmap _originalImage;

        /// <summary>
        /// 表示中の画像
        /// </summary>
        public Bitmap DisplayedImage 
        { 
            get
            {
                return new Bitmap(pcbMain.Image);
            }
            set
            {
                if (value != null)
                {
                    pcbMain.Image = value;
                    DrawRgbHistgram(value);
                }
            }
        }

        /// <summary>
        /// FileNameからBitmapオブジェクトの作成
        /// </summary>
        /// <param name="fileName"></param>
        private Bitmap GetBitmapFromFilename(string fileName)
        {
            if (File.Exists(fileName))
            {
                Bitmap bmp;
                using (var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                {
                    bmp = new Bitmap(fs);
                }
                return bmp;
            }
            else
            {
                return null;
            }

        }

        /// <summary>
        /// ドラッグされたファイル名の取得
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        private string GetFileNameToDragEvent(DragEventArgs e)
        {
            string[] fileName = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (File.Exists(fileName[0]) == true)
            {
                // 拡張子の確認および小文字化
                string ext = Path.GetExtension(fileName[0]).ToLower();

                // 画像ファイル拡張子かの確認
                if ((ext == ".bmp") || (ext == ".jpg") || (ext == ".png") || (ext == ".tif"))
                {
                    return fileName[0]; ;
                }
                else
                {
                    MessageBox.Show("画像ファイルではありません", "Error!");
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// RGB輝度ヒストグラムの描画
        /// </summary>
        /// <param name="bmp"></param>
        private void DrawRgbHistgram(Bitmap bmp)
        {
            int[][] LUT = bmp.CreateRgbHistgramArray();
            #region RGBヒストグラム
            // Chartコントロール内のグラフ、凡例、目盛り領域を削除
            chtRgb.Series.Clear();
            chtRgb.Legends.Clear();
            chtRgb.ChartAreas.Clear();
            chtRgb.Titles.Clear();

            // 目盛り領域の設定
            var caRGB = chtRgb.ChartAreas.Add("Histogram");

            // グラフタイトル
            Title titleRGB = new Title("RGBヒストグラム");
            chtRgb.Titles.Add(titleRGB);

            // X軸
            caRGB.AxisX.Minimum = 0;           // 最小値
            caRGB.AxisX.Maximum = 255;         // 最大値
            caRGB.AxisX.Interval = 51;         // 目盛りの間隔


            // グラフの系列を追加
            var serR = chtRgb.Series.Add("HistogramR");
            var serG = chtRgb.Series.Add("HistogramG");
            var serB = chtRgb.Series.Add("HistogramB");

            // グラフの種類をスプライン面グラフに設定する
            serR.ChartType = serG.ChartType = serB.ChartType
                = SeriesChartType.SplineArea;

            // 輪郭線の太さ
            serR.BorderWidth = serG.BorderWidth = serB.BorderWidth = 2;

            // 輪郭線の色
            serR.BorderColor = Color.Red;
            serG.BorderColor = Color.Green;
            serB.BorderColor = Color.Blue;

            // 塗りつぶしの色の設定（半透明）
            serR.Color = Color.FromArgb(150, Color.Red);
            serG.Color = Color.FromArgb(150, Color.Green);
            serB.Color = Color.FromArgb(150, Color.Blue);

            // データ設定
            for (int i = 0; i < LUT[0].Length; i++)
            {
                serR.Points.Add(LUT[0][i]);
                serG.Points.Add(LUT[1][i]);
                serB.Points.Add(LUT[2][i]);
            }
            #endregion
            #region R/G/B単体ヒストグラム
            Action<string, Chart, int[], Color> drawEachHistgram = (elementName, cht, lut, color) =>
            {
                // Chartコントロール内のグラフ、凡例、目盛り領域を削除
                cht.Series.Clear();
                cht.Legends.Clear();
                cht.ChartAreas.Clear();
                cht.Titles.Clear();

                // 目盛り領域の設定
                var ca = cht.ChartAreas.Add("Histogram");

                // グラフタイトル
                Title titleG = new Title($"{elementName}ヒストグラム");
                cht.Titles.Add(titleG);

                // X軸
                ca.AxisX.Minimum = 0;           // 最小値
                ca.AxisX.Maximum = 255;         // 最大値
                ca.AxisX.Interval = 51;         // 目盛りの間隔


                // グラフの系列を追加
                var ser = cht.Series.Add($"Histogram{elementName}");

                // グラフの種類をスプライン面グラフに設定する
                ser.ChartType = SeriesChartType.SplineArea;

                // 輪郭線の太さ
                ser.BorderWidth = 2;

                // 輪郭線の色
                ser.BorderColor = color;

                // 塗りつぶしの色の設定（半透明）
                ser.Color = Color.FromArgb(150, color);

                // データ設定
                for (int i = 0; i < lut.Length; i++)
                {
                    ser.Points.Add(lut[i]);
                }
            };
            drawEachHistgram("R", chtR, LUT[0], Color.Red);
            drawEachHistgram("G", chtG, LUT[1], Color.Green);
            drawEachHistgram("B", chtB, LUT[2], Color.Blue);
            #endregion
        }
    }
}
