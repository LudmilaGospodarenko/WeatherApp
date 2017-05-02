﻿using System;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Logic
{
    [SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class current
    {

        private currentCity cityField;

        private currentTemperature temperatureField;

        private currentHumidity humidityField;

        private currentPressure pressureField;

        private currentWind windField;

        private currentClouds cloudsField;

        private currentVisibility visibilityField;

        private currentPrecipitation precipitationField;

        private currentWeather weatherField;

        private currentLastupdate lastupdateField;

        public currentCity city
        {
            get { return this.cityField; }
            set { this.cityField = value; }
        }


        public currentTemperature temperature
        {
            get { return this.temperatureField; }
            set { this.temperatureField = value; }
        }

        public currentHumidity humidity
        {
            get { return this.humidityField; }
            set { this.humidityField = value; }
        }

        public currentPressure pressure
        {
            get { return this.pressureField; }
            set { this.pressureField = value; }
        }

        public currentWind wind
        {
            get { return this.windField; }
            set { this.windField = value; }
        }

        public currentClouds clouds
        {
            get { return this.cloudsField; }
            set { this.cloudsField = value; }
        }

        public currentVisibility visibility
        {
            get { return this.visibilityField; }
            set { this.visibilityField = value; }
        }

        public currentPrecipitation precipitation
        {
            get { return this.precipitationField; }
            set { this.precipitationField = value; }
        }

        public currentWeather weather
        {
            get { return this.weatherField; }
            set { this.weatherField = value; }
        }

        public currentLastupdate lastupdate
        {
            get { return this.lastupdateField; }
            set { this.lastupdateField = value; }
        }
    }


    [SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class currentCity
    {

        private currentCityCoord coordField;

        private string countryField;

        private currentCitySun sunField;

        private uint idField;

        private string nameField;

        public currentCityCoord coord
        {
            get { return this.coordField; }
            set { this.coordField = value; }
        }

        public string country
        {
            get { return this.countryField; }
            set { this.countryField = value; }
        }

        public currentCitySun sun
        {
            get { return this.sunField; }
            set { this.sunField = value; }
        }

        [XmlAttributeAttribute()]
        public uint id
        {
            get { return this.idField; }
            set { this.idField = value; }
        }

        [XmlAttributeAttribute()]
        public string name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }
    }


    [SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class currentCityCoord
    {

        private decimal lonField;

        private decimal latField;

        [XmlAttributeAttribute()]
        public decimal lon
        {
            get { return this.lonField; }
            set { this.lonField = value; }
        }

        [XmlAttributeAttribute()]
        public decimal lat
        {
            get { return this.latField; }
            set { this.latField = value; }
        }
    }

    [SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class currentCitySun
    {

        private DateTime riseField;

        private DateTime setField;

        [XmlAttributeAttribute()]
        public DateTime rise
        {
            get { return this.riseField; }
            set { this.riseField = value; }
        }

        [XmlAttributeAttribute()]
        public DateTime set
        {
            get { return this.setField; }
            set { this.setField = value; }
        }
    }

    [SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class currentTemperature
    {

        private byte valueField;

        private byte minField;

        private byte maxField;

        private string unitField;

        [XmlAttributeAttribute()]
        public byte value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }

        [XmlAttributeAttribute()]
        public byte min
        {
            get { return this.minField; }
            set { this.minField = value; }
        }

        [XmlAttributeAttribute()]
        public byte max
        {
            get { return this.maxField; }
            set { this.maxField = value; }
        }

        [XmlAttributeAttribute()]
        public string unit
        {
            get { return this.unitField; }
            set { this.unitField = value; }
        }
    }


    [SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class currentHumidity
    {

        private byte valueField;

        private string unitField;


        [XmlAttributeAttribute()]
        public byte value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }

        [XmlAttributeAttribute()]
        public string unit
        {
            get { return this.unitField; }
            set { this.unitField = value; }
        }
    }

    [SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class currentPressure
    {

        private ushort valueField;

        private string unitField;

        [XmlAttributeAttribute()]
        public ushort value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }

        [XmlAttributeAttribute()]
        public string unit
        {
            get { return this.unitField; }
            set { this.unitField = value; }
        }
    }

    [SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class currentWind
    {

        private currentWindSpeed speedField;

        private object gustsField;

        private currentWindDirection directionField;

        public currentWindSpeed speed
        {
            get { return this.speedField; }
            set { this.speedField = value; }
        }

        public object gusts
        {
            get { return this.gustsField; }
            set { this.gustsField = value; }
        }

        public currentWindDirection direction
        {
            get { return this.directionField; }
            set { this.directionField = value; }
        }
    }

    [SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class currentWindSpeed
    {

        private byte valueField;

        private string nameField;

        [XmlAttributeAttribute()]
        public byte value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }

        [XmlAttributeAttribute()]
        public string name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }
    }

    [SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class currentWindDirection
    {

        private byte valueField;

        private string codeField;

        private string nameField;

        [XmlAttributeAttribute()]
        public byte value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }

        [XmlAttributeAttribute()]
        public string code
        {
            get { return this.codeField; }
            set { this.codeField = value; }
        }

        [XmlAttributeAttribute()]
        public string name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }
    }

    [SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class currentClouds
    {

        private byte valueField;

        private string nameField;

        [XmlAttributeAttribute()]
        public byte value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }

        [XmlAttributeAttribute()]
        public string name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }
    }

    [SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class currentVisibility
    {

        private ushort valueField;

        [XmlAttributeAttribute()]
        public ushort value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }
    }

    [SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class currentPrecipitation
    {

        private string modeField;

        [XmlAttributeAttribute()]
        public string mode
        {
            get { return this.modeField; }
            set { this.modeField = value; }
        }
    }

    [SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class currentWeather
    {

        private ushort numberField;

        private string valueField;

        private string iconField;

        [XmlAttributeAttribute()]
        public ushort number
        {
            get { return this.numberField; }
            set { this.numberField = value; }
        }

        [XmlAttributeAttribute()]
        public string value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }

        [XmlAttributeAttribute()]
        public string icon
        {
            get { return this.iconField; }
            set { this.iconField = value; }
        }
    }

    [SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class currentLastupdate
    {

        private DateTime valueField;

        [XmlAttributeAttribute()]
        public DateTime value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }
    }
}
