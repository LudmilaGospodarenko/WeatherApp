using System;
using System.Xml.Serialization;
using System.ComponentModel;

namespace WeatherApp.Logic
{
    /// This class is for parsing of Forecast responce from WS/>
    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class weatherdata
    {

        private weatherdataLocation locationField;

        private object creditField;

        private weatherdataMeta metaField;

        private weatherdataSun sunField;

        private weatherdataTime[] forecastField;

        /// <remarks/>
        public weatherdataLocation location
        {
            get
            {
                return this.locationField;
            }
            set
            {
                this.locationField = value;
            }
        }

        /// <remarks/>
        public object credit
        {
            get
            {
                return this.creditField;
            }
            set
            {
                this.creditField = value;
            }
        }

        /// <remarks/>
        public weatherdataMeta meta
        {
            get
            {
                return this.metaField;
            }
            set
            {
                this.metaField = value;
            }
        }

        /// <remarks/>
        public weatherdataSun sun
        {
            get
            {
                return this.sunField;
            }
            set
            {
                this.sunField = value;
            }
        }

        /// <remarks/>
        [XmlArrayItemAttribute("time", IsNullable = false)]
        public weatherdataTime[] forecast
        {
            get
            {
                return this.forecastField;
            }
            set
            {
                this.forecastField = value;
            }
        }
    }

    /// <remarks/>
    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class weatherdataLocation
    {

        private string nameField;

        private object typeField;

        private string countryField;

        private object timezoneField;

        private weatherdataLocationLocation locationField;

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public object type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        public string country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }

        /// <remarks/>
        public object timezone
        {
            get
            {
                return this.timezoneField;
            }
            set
            {
                this.timezoneField = value;
            }
        }

        /// <remarks/>
        public weatherdataLocationLocation location
        {
            get
            {
                return this.locationField;
            }
            set
            {
                this.locationField = value;
            }
        }
    }

    /// <remarks/>
    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class weatherdataLocationLocation
    {

        private decimal altitudeField;

        private decimal latitudeField;

        private decimal longitudeField;

        private string geobaseField;

        private uint geobaseidField;

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal altitude
        {
            get
            {
                return this.altitudeField;
            }
            set
            {
                this.altitudeField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal latitude
        {
            get
            {
                return this.latitudeField;
            }
            set
            {
                this.latitudeField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal longitude
        {
            get
            {
                return this.longitudeField;
            }
            set
            {
                this.longitudeField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string geobase
        {
            get
            {
                return this.geobaseField;
            }
            set
            {
                this.geobaseField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public uint geobaseid
        {
            get
            {
                return this.geobaseidField;
            }
            set
            {
                this.geobaseidField = value;
            }
        }
    }

    /// <remarks/>
    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class weatherdataMeta
    {

        private object lastupdateField;

        private decimal calctimeField;

        private object nextupdateField;

        /// <remarks/>
        public object lastupdate
        {
            get
            {
                return this.lastupdateField;
            }
            set
            {
                this.lastupdateField = value;
            }
        }

        /// <remarks/>
        public decimal calctime
        {
            get
            {
                return this.calctimeField;
            }
            set
            {
                this.calctimeField = value;
            }
        }

        /// <remarks/>
        public object nextupdate
        {
            get
            {
                return this.nextupdateField;
            }
            set
            {
                this.nextupdateField = value;
            }
        }
    }

    /// <remarks/>
    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class weatherdataSun
    {

        private DateTime riseField;

        private DateTime setField;

        /// <remarks/>
        [XmlAttributeAttribute()]
        public DateTime rise
        {
            get
            {
                return this.riseField;
            }
            set
            {
                this.riseField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public DateTime set
        {
            get
            {
                return this.setField;
            }
            set
            {
                this.setField = value;
            }
        }
    }

    /// <remarks/>
    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class weatherdataTime
    {

        private weatherdataTimeSymbol symbolField;

        private weatherdataTimePrecipitation precipitationField;

        private weatherdataTimeWindDirection windDirectionField;

        private weatherdataTimeWindSpeed windSpeedField;

        private weatherdataTimeTemperature temperatureField;

        private weatherdataTimePressure pressureField;

        private weatherdataTimeHumidity humidityField;

        private weatherdataTimeClouds cloudsField;

        private DateTime fromField;

        private DateTime toField;

        /// <remarks/>
        public weatherdataTimeSymbol symbol
        {
            get
            {
                return this.symbolField;
            }
            set
            {
                this.symbolField = value;
            }
        }

        /// <remarks/>
        public weatherdataTimePrecipitation precipitation
        {
            get
            {
                return this.precipitationField;
            }
            set
            {
                this.precipitationField = value;
            }
        }

        /// <remarks/>
        public weatherdataTimeWindDirection windDirection
        {
            get
            {
                return this.windDirectionField;
            }
            set
            {
                this.windDirectionField = value;
            }
        }

        /// <remarks/>
        public weatherdataTimeWindSpeed windSpeed
        {
            get
            {
                return this.windSpeedField;
            }
            set
            {
                this.windSpeedField = value;
            }
        }

        /// <remarks/>
        public weatherdataTimeTemperature temperature
        {
            get
            {
                return this.temperatureField;
            }
            set
            {
                this.temperatureField = value;
            }
        }

        /// <remarks/>
        public weatherdataTimePressure pressure
        {
            get
            {
                return this.pressureField;
            }
            set
            {
                this.pressureField = value;
            }
        }

        /// <remarks/>
        public weatherdataTimeHumidity humidity
        {
            get
            {
                return this.humidityField;
            }
            set
            {
                this.humidityField = value;
            }
        }

        /// <remarks/>
        public weatherdataTimeClouds clouds
        {
            get
            {
                return this.cloudsField;
            }
            set
            {
                this.cloudsField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public DateTime from
        {
            get
            {
                return this.fromField;
            }
            set
            {
                this.fromField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public DateTime to
        {
            get
            {
                return this.toField;
            }
            set
            {
                this.toField = value;
            }
        }
    }

    /// <remarks/>
    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class weatherdataTimeSymbol
    {

        private ushort numberField;

        private string nameField;

        private string varField;

        /// <remarks/>
        [XmlAttributeAttribute()]
        public ushort number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string var
        {
            get
            {
                return this.varField;
            }
            set
            {
                this.varField = value;
            }
        }
    }

    /// <remarks/>
    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class weatherdataTimePrecipitation
    {

        private string unitField;

        private decimal valueField;

        private bool valueFieldSpecified;

        private string typeField;

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool valueSpecified
        {
            get
            {
                return this.valueFieldSpecified;
            }
            set
            {
                this.valueFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class weatherdataTimeWindDirection
    {

        private decimal degField;

        private string codeField;

        private string nameField;

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal deg
        {
            get
            {
                return this.degField;
            }
            set
            {
                this.degField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class weatherdataTimeWindSpeed
    {

        private decimal mpsField;

        private string nameField;

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal mps
        {
            get
            {
                return this.mpsField;
            }
            set
            {
                this.mpsField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class weatherdataTimeTemperature
    {

        private string unitField;

        private decimal valueField;

        private decimal minField;

        private decimal maxField;

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal min
        {
            get
            {
                return this.minField;
            }
            set
            {
                this.minField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal max
        {
            get
            {
                return this.maxField;
            }
            set
            {
                this.maxField = value;
            }
        }
    }

    /// <remarks/>
    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class weatherdataTimePressure
    {

        private string unitField;

        private decimal valueField;

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class weatherdataTimeHumidity
    {

        private decimal valueField;

        private string unitField;

        /// <remarks/>
        [XmlAttribute()]
        public decimal value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class weatherdataTimeClouds
    {

        private string valueField;

        private decimal allField;

        private string unitField;

        /// <remarks/>
        [XmlAttribute()]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public decimal all
        {
            get
            {
                return this.allField;
            }
            set
            {
                this.allField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }
    }

}