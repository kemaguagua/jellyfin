﻿using System.Xml.Serialization;
using MediaBrowser.Controller.Dlna;
using MediaBrowser.Model.Dlna;

namespace MediaBrowser.Dlna.Profiles
{
    [XmlRoot("Profile")]
    public class XboxOneProfile : DefaultProfile
    {
        public XboxOneProfile()
        {
            Name = "Xbox One";

            Identification = new DeviceIdentification
            {
                ModelName = "Xbox One",
                FriendlyName = "Xbox-SystemOS"
            };

            TranscodingProfiles = new[]
            {
                new TranscodingProfile
                {
                    Container = "mp3",
                    AudioCodec = "mp3",
                    Type = DlnaProfileType.Audio
                },
                new TranscodingProfile
                {
                    Container = "ts",
                    VideoCodec = "h264",
                    AudioCodec = "aac",
                    Type = DlnaProfileType.Video
                }
            };

            DirectPlayProfiles = new[]
            {
                new DirectPlayProfile
                {
                    Container = "mp3,wma",
                    Type = DlnaProfileType.Audio
                }
            };

            ResponseProfiles = new[]
            {
                new ResponseProfile
                {
                    Container = "avi",
                    MimeType = "video/x-msvideo",
                    Type = DlnaProfileType.Video
                }
            };
        }
    }
}