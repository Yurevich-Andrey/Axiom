﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
// Disable XML Comment warnings
#pragma warning disable 1591
#pragma warning disable 1587
#pragma warning disable 1570

namespace Axiom
{
    public class ViewModel : INotifyPropertyChanged
    {
        public ViewModel()
        {
            //cbo1_Items = new ObservableCollection<string>();
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        private void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler(this, new PropertyChangedEventArgs(name));
        }

        //private ObservableCollection<string> _cbo1_Items;
        //public ObservableCollection<string> cbo1_Items
        //{
        //    get { return _cbo1_Items; }
        //    set
        //    {
        //        _cbo1_Items = value;
        //        OnPropertyChanged("cbo1_Items");
        //    }
        //}


        // --------------------------------------------------------------------------------------------------------
        /// <summary>
        ///     Format
        /// </summary>
        // --------------------------------------------------------------------------------------------------------
        // -------------------------
        // Containers
        // -------------------------
        // Items
        public static ObservableCollection<string> _cboFormat_Items = new ObservableCollection<string>()
        {
            "webm",
            "mp4",
            "mkv",
            "m2v",
            "mpg",
            "avi",
            "ogv",
            "mp3",
            "m4a",
            "ogg",
            "flac",
            "wav",
            "jpg",
            "png",
            "webp"
        };

        public static ObservableCollection<string> cboFormat_Items
        {
            get { return _cboFormat_Items; }
            set { _cboFormat_Items = value; }
        }
        //public static ObservableCollection<FormatItem> _cboFormat_Items = new ObservableCollection<FormatItem>()
        //{
        //    new FormatItem() { Name = "webm", Category = "Video" },
        //    new FormatItem() { Name = "mp4", Category = "Video" },
        //};

        //public static ObservableCollection<FormatItem> cboFormat_Items
        //{
        //    get { return _cboFormat_Items; }
        //    set { _cboFormat_Items = value; }
        //}

        //public class FormatItem
        //{
        //    public string Name { get; set; }
        //    public string Category { get; set; }
        //}
        // Selected Item
        //public static string cboFormat_SelectedItem { get; set; }

        // -------------------------
        // Hardware Accel
        // -------------------------
        public static string cboHWAccel_SelectedItem { get; set; }


        // --------------------------------------------------------------------------------------------------------
        /// <summary>
        ///     Video
        /// </summary>
        // --------------------------------------------------------------------------------------------------------
        // -------------------------
        // Video Codec
        // -------------------------
        // Items
        //public List<string> _cboVideoCodec_Items = new List<string>();
        //public List<string> cboVideoCodec_Items
        //{
        //    get { return _cboVideoCodec_Items; }
        //    set
        //    {
        //        _cboVideoCodec_Items = value;
        //        OnPropertyChanged("cboVideoCodec_Items");
        //    }
        //}

        // Selected Item
        //public static string cboVideoCodec_SelectedItem { get; set; }
        public string _cboVideoCodec_SelectedItem { get; set; }
        public string cboVideoCodec_SelectedItem
        {
            get { return _cboVideoCodec_SelectedItem; }
            set
            {
                if (_cboVideoCodec_SelectedItem == value)
                {
                    return;
                }

                _cboVideoCodec_SelectedItem = value;
                OnPropertyChanged("cboVideoCodec_SelectedItem");
            }
        }

        // -------------------------
        // Encoding Pass
        // -------------------------
        public static string cboVideoEncodingPass_SelectedItem { get; set; }

        // -------------------------
        // Video Quality
        // -------------------------
        public static string cboVideoQuality_SelectedItem { get; set; }

        // -------------------------
        // VBR
        // -------------------------
        private static bool _tglVideoVBR_IsChecked;
        public static bool tglVideoVBR_IsChecked
        {
            get { return _tglVideoVBR_IsChecked; }
            set
            {
                if (_tglVideoVBR_IsChecked == value) return;

                _tglVideoVBR_IsChecked = value;

                //NotifyPropertyChanged(() => IsSelected);
            }
        }


        // --------------------------------------------------------------------------------------------------------
        /// <summary>
        ///     Audio
        /// </summary>
        // --------------------------------------------------------------------------------------------------------
        // -------------------------
        // Audio Codec
        // -------------------------
        public static string cboAudioCodec_SelectedItem { get; set; }

        // -------------------------
        // Audio Quality
        // -------------------------
        public static string cboAudioQuality_SelectedItem { get; set; }

        // -------------------------
        // VBR
        // -------------------------
        private static bool _Audio_VBR_IsChecked;
        public static bool Audio_VBR_IsChecked
        {
            get { return _Audio_VBR_IsChecked; }
            set
            {
                if (_Audio_VBR_IsChecked == value) return;

                _Audio_VBR_IsChecked = value;

                //NotifyPropertyChanged(() => IsSelected);
            }
        }



        // --------------------------------------------------------------------------------------------------------
        /// <summary>
        ///     Video Filters
        /// </summary>
        // --------------------------------------------------------------------------------------------------------
        // -------------------------
        // Deband
        // -------------------------
        // Items
        public static ObservableCollection<string> _cboFilterVideo_Deband_Items = new ObservableCollection<string>()
        {
            "disabled",
            "enabled"
        };
        public static ObservableCollection<string> cboFilterVideo_Deband_Items
        {
            get { return _cboFilterVideo_Deband_Items; }
            set { _cboFilterVideo_Deband_Items = value; }
        }

        // Selected Item
        public static string cboFilterVideo_Deband_SelectedItem { get; set; }


        // -------------------------
        // Deshake
        // -------------------------
        public static ObservableCollection<string> _cboFilterVideo_Deshake_Items = new ObservableCollection<string>()
        {
            "disabled",
            "enabled"
        };
        public static ObservableCollection<string> cboFilterVideo_Deshake_Items
        {
            get { return _cboFilterVideo_Deshake_Items; }
            set { _cboFilterVideo_Deshake_Items = value; }
        }

        // Selected Item
        public static string cboFilterVideo_Deshake_SelectedItem { get; set; }


        // -------------------------
        // Deflicker
        // -------------------------
        public static ObservableCollection<string> _cboFilterVideo_Deflicker_Items = new ObservableCollection<string>()
        {
            "disabled",
            "enabled"
        };
        public static ObservableCollection<string> cboFilterVideo_Deflicker_Items
        {
            get { return _cboFilterVideo_Deflicker_Items; }
            set { _cboFilterVideo_Deflicker_Items = value; }
        }

        public static string cboFilterVideo_Deflicker_SelectedItem { get; set; }


        // -------------------------
        // Dejudder
        // -------------------------
        public static ObservableCollection<string> _cboFilterVideo_Dejudder_Items = new ObservableCollection<string>()
        {
            "disabled",
            "enabled"
        };
        public static ObservableCollection<string> cboFilterVideo_Dejudder_Items
        {
            get { return _cboFilterVideo_Dejudder_Items; }
            set { _cboFilterVideo_Dejudder_Items = value; }
        }

        public static string cboFilterVideo_Dejudder_SelectedItem { get; set; }

        // -------------------------
        // Denoise
        // -------------------------
        public static ObservableCollection<string> _cboFilterVideo_Denoise_Items = new ObservableCollection<string>()
        {
            "disabled",
            "default",
            "light",
            "medium",
            "heavy",
        };
        public static ObservableCollection<string> cboFilterVideo_Denoise_Items
        {
            get { return _cboFilterVideo_Denoise_Items; }
            set { _cboFilterVideo_Denoise_Items = value; }
        }

        public static string cboFilterVideo_Denoise_SelectedItem { get; set; }


        // -------------------------
        // Selective Color
        // -------------------------
        // -------------------------
        // Correction Method
        // -------------------------
        public static ObservableCollection<string> _cboFilterVideo_SelectiveColor_Correction_Method_Items = new ObservableCollection<string>()
        {
            "relative",
            "absolute"
        };
        public static ObservableCollection<string> cboFilterVideo_SelectiveColor_Correction_Method_Items
        {
            get { return _cboFilterVideo_SelectiveColor_Correction_Method_Items; }
            set { _cboFilterVideo_SelectiveColor_Correction_Method_Items = value; }
        }

        public static string cboFilterVideo_SelectiveColor_Correction_Method_SelectedItem { get; set; }


        // --------------------------------------------------------------------------------------------------------
        /// <summary>
        ///     Audio Filters
        /// </summary>
        // --------------------------------------------------------------------------------------------------------
        // -------------------------
        // Lowpass
        // -------------------------
        public static ObservableCollection<string> _cboFilterAudio_Lowpass_Items = new ObservableCollection<string>()
        {
            "disabled",
            "enabled"
        };
        public static ObservableCollection<string> cboFilterAudio_Lowpass_Items
        {
            get { return _cboFilterAudio_Lowpass_Items; }
            set { _cboFilterAudio_Lowpass_Items = value; }
        }

        public static string cboFilterAudio_Lowpass_SelectedItem { get; set; }

        // -------------------------
        // Highpass
        // -------------------------
        public static ObservableCollection<string> _cboFilterAudio_Highpass_Items = new ObservableCollection<string>()
        {
            "disabled",
            "enabled"
        };
        public static ObservableCollection<string> cboFilterAudio_Highpass_Items
        {
            get { return _cboFilterAudio_Highpass_Items; }
            set { _cboFilterAudio_Highpass_Items = value; }
        }

        public static string cboFilterAudio_Highpass_SelectedItem { get; set; }

        // -------------------------
        // Headphones (Earwax)
        // -------------------------
        public static ObservableCollection<string> _cboFilterAudio_Headphones_Items = new ObservableCollection<string>()
        {
            "disabled",
            "enabled"
        };
        public static ObservableCollection<string> cboFilterAudio_Headphones_Items
        {
            get { return _cboFilterAudio_Headphones_Items; }
            set { _cboFilterAudio_Headphones_Items = value; }
        }

        public static string cboFilterAudio_Headphones_SelectedItem { get; set; }


    }
}
