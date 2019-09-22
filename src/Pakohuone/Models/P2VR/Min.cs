﻿using System.Xml.Serialization;

namespace Pakohuone.Models.Pano2VR
{
    [XmlRoot(ElementName = "min")]
    public class Min
    {
        [XmlAttribute(AttributeName = "fov")]
        public string Fov { get; set; }
        [XmlAttribute(AttributeName = "pan")]
        public string Pan { get; set; }
        [XmlAttribute(AttributeName = "tilt")]
        public string Tilt { get; set; }
    }
}
