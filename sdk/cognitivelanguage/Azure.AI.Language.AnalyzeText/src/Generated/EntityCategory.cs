// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Language.AnalyzeText
{
    public readonly partial struct EntityCategory : IEquatable<EntityCategory>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EntityCategory"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EntityCategory(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AddressValue = "Address";
        private const string NumericValue = "Numeric";
        private const string AgeValue = "Age";
        private const string CurrencyValue = "Currency";
        private const string NumberValue = "Number";
        private const string NumberRangeValue = "NumberRange";
        private const string PercentageValue = "Percentage";
        private const string OrdinalValue = "Ordinal";
        private const string TemperatureValue = "Temperature";
        private const string DimensionValue = "Dimension";
        private const string LengthValue = "Length";
        private const string WeightValue = "Weight";
        private const string HeightValue = "Height";
        private const string SpeedValue = "Speed";
        private const string AreaValue = "Area";
        private const string VolumeValue = "Volume";
        private const string InformationValue = "Information";
        private const string TemporalValue = "Temporal";
        private const string DateValue = "Date";
        private const string TimeValue = "Time";
        private const string DateTimeValue = "DateTime";
        private const string DateRangeValue = "DateRange";
        private const string TimeRangeValue = "TimeRange";
        private const string DateTimeRangeValue = "DateTimeRange";
        private const string DurationValue = "Duration";
        private const string SetTemporalValue = "SetTemporal";
        private const string EventValue = "Event";
        private const string SportsEventValue = "SportsEvent";
        private const string CulturalEventValue = "CulturalEvent";
        private const string NaturalEventValue = "NaturalEvent";
        private const string LocationValue = "Location";
        private const string GPEValue = "GPE";
        private const string CityValue = "City";
        private const string StateValue = "State";
        private const string CountryRegionValue = "CountryRegion";
        private const string ContinentValue = "Continent";
        private const string StructuralValue = "Structural";
        private const string AirportValue = "Airport";
        private const string GeologicalValue = "Geological";
        private const string OrganizationValue = "Organization";
        private const string OrganizationMedicalValue = "OrganizationMedical";
        private const string OrganizationStockExchangeValue = "OrganizationStockExchange";
        private const string OrganizationSportsValue = "OrganizationSports";
        private const string PersonValue = "Person";
        private const string PersonTypeValue = "PersonType";
        private const string EmailValue = "Email";
        private const string URLValue = "URL";
        private const string IPValue = "IP";
        private const string PhoneNumberValue = "PhoneNumber";
        private const string ProductValue = "Product";
        private const string ComputingProductValue = "ComputingProduct";
        private const string SkillValue = "Skill";

        /// <summary> Specific street-level mentions of locations: house/building numbers, streets, avenues, highways, intersections referenced by name. </summary>
        public static EntityCategory Address { get; } = new EntityCategory(AddressValue);
        /// <summary> Numeric values, including digits and number words. </summary>
        public static EntityCategory Numeric { get; } = new EntityCategory(NumericValue);
        /// <summary> Age-related values. </summary>
        public static EntityCategory Age { get; } = new EntityCategory(AgeValue);
        /// <summary> Currency-related values. </summary>
        public static EntityCategory Currency { get; } = new EntityCategory(CurrencyValue);
        /// <summary> Numbers without a unit. </summary>
        public static EntityCategory Number { get; } = new EntityCategory(NumberValue);
        /// <summary> Range of Numbers. </summary>
        public static EntityCategory NumberRange { get; } = new EntityCategory(NumberRangeValue);
        /// <summary> Percentage-related values. </summary>
        public static EntityCategory Percentage { get; } = new EntityCategory(PercentageValue);
        /// <summary> Ordinal numbers. </summary>
        public static EntityCategory Ordinal { get; } = new EntityCategory(OrdinalValue);
        /// <summary> Temperature-related values. </summary>
        public static EntityCategory Temperature { get; } = new EntityCategory(TemperatureValue);
        /// <summary> Dimension of measurements. </summary>
        public static EntityCategory Dimension { get; } = new EntityCategory(DimensionValue);
        /// <summary> Length of an object. </summary>
        public static EntityCategory Length { get; } = new EntityCategory(LengthValue);
        /// <summary> Weight of an object. </summary>
        public static EntityCategory Weight { get; } = new EntityCategory(WeightValue);
        /// <summary> Height of an object. </summary>
        public static EntityCategory Height { get; } = new EntityCategory(HeightValue);
        /// <summary> Speed of an object. </summary>
        public static EntityCategory Speed { get; } = new EntityCategory(SpeedValue);
        /// <summary> Area of an object. </summary>
        public static EntityCategory Area { get; } = new EntityCategory(AreaValue);
        /// <summary> Volume of an object. </summary>
        public static EntityCategory Volume { get; } = new EntityCategory(VolumeValue);
        /// <summary> Unit of measure for digital information. </summary>
        public static EntityCategory Information { get; } = new EntityCategory(InformationValue);
        /// <summary> Items relating to time. </summary>
        public static EntityCategory Temporal { get; } = new EntityCategory(TemporalValue);
        /// <summary> Calendar dates. </summary>
        public static EntityCategory Date { get; } = new EntityCategory(DateValue);
        /// <summary> Times of day. </summary>
        public static EntityCategory Time { get; } = new EntityCategory(TimeValue);
        /// <summary> Calendar dates with time. </summary>
        public static EntityCategory DateTime { get; } = new EntityCategory(DateTimeValue);
        /// <summary> Range of dates. </summary>
        public static EntityCategory DateRange { get; } = new EntityCategory(DateRangeValue);
        /// <summary> Range of times. </summary>
        public static EntityCategory TimeRange { get; } = new EntityCategory(TimeRangeValue);
        /// <summary> Range of date and time. </summary>
        public static EntityCategory DateTimeRange { get; } = new EntityCategory(DateTimeRangeValue);
        /// <summary> Duration of time. </summary>
        public static EntityCategory Duration { get; } = new EntityCategory(DurationValue);
        /// <summary> Set of time-related values. </summary>
        public static EntityCategory SetTemporal { get; } = new EntityCategory(SetTemporalValue);
        /// <summary> Social, sports, business, political, educational, natural, historical, criminal, violent, legal, military events with a timed period. </summary>
        public static EntityCategory Event { get; } = new EntityCategory(EventValue);
        /// <summary> Sports event-related values. </summary>
        public static EntityCategory SportsEvent { get; } = new EntityCategory(SportsEventValue);
        /// <summary> Cultural event-related values. </summary>
        public static EntityCategory CulturalEvent { get; } = new EntityCategory(CulturalEventValue);
        /// <summary> Natural event-related values. </summary>
        public static EntityCategory NaturalEvent { get; } = new EntityCategory(NaturalEventValue);
        /// <summary> Particular point or place in physical space. </summary>
        public static EntityCategory Location { get; } = new EntityCategory(LocationValue);
        /// <summary> Cities, countries/regions, states. </summary>
        public static EntityCategory GPE { get; } = new EntityCategory(GPEValue);
        /// <summary> City-related values. </summary>
        public static EntityCategory City { get; } = new EntityCategory(CityValue);
        /// <summary> State-related values. </summary>
        public static EntityCategory State { get; } = new EntityCategory(StateValue);
        /// <summary> Country or region-related values. </summary>
        public static EntityCategory CountryRegion { get; } = new EntityCategory(CountryRegionValue);
        /// <summary> Continent-related values. </summary>
        public static EntityCategory Continent { get; } = new EntityCategory(ContinentValue);
        /// <summary> Manmade structures. </summary>
        public static EntityCategory Structural { get; } = new EntityCategory(StructuralValue);
        /// <summary> Airports. </summary>
        public static EntityCategory Airport { get; } = new EntityCategory(AirportValue);
        /// <summary> Geographic and natural features such as rivers, oceans, and deserts. </summary>
        public static EntityCategory Geological { get; } = new EntityCategory(GeologicalValue);
        /// <summary> Corporations, agencies, and other groups of people defined by some established organizational structure. These labels can include companies, political parties/movements, musical bands, sport clubs, government bodies, and public organizations. Nationalities or religions are not ORGANIZATION. </summary>
        public static EntityCategory Organization { get; } = new EntityCategory(OrganizationValue);
        /// <summary> Medical companies and groups. </summary>
        public static EntityCategory OrganizationMedical { get; } = new EntityCategory(OrganizationMedicalValue);
        /// <summary> Stock exchange groups. </summary>
        public static EntityCategory OrganizationStockExchange { get; } = new EntityCategory(OrganizationStockExchangeValue);
        /// <summary> Sports-related organizations. </summary>
        public static EntityCategory OrganizationSports { get; } = new EntityCategory(OrganizationSportsValue);
        /// <summary> First, last, and middle names, names of fictional characters, and aliases. Titles, such as 'Mr.' or 'President', are not considered part of the named entity. </summary>
        public static EntityCategory Person { get; } = new EntityCategory(PersonValue);
        /// <summary> Human roles classified by a group membership. </summary>
        public static EntityCategory PersonType { get; } = new EntityCategory(PersonTypeValue);
        /// <summary> Email addresses. </summary>
        public static EntityCategory Email { get; } = new EntityCategory(EmailValue);
        /// <summary> URLs to websites. </summary>
        public static EntityCategory URL { get; } = new EntityCategory(URLValue);
        /// <summary> network IP addresses. </summary>
        public static EntityCategory IP { get; } = new EntityCategory(IPValue);
        /// <summary> Phone numbers (US and EU phone numbers only). </summary>
        public static EntityCategory PhoneNumber { get; } = new EntityCategory(PhoneNumberValue);
        /// <summary> Single or group of commercial, consumable objects, electronics, vehicles, food groups. </summary>
        public static EntityCategory Product { get; } = new EntityCategory(ProductValue);
        /// <summary> Computing products. </summary>
        public static EntityCategory ComputingProduct { get; } = new EntityCategory(ComputingProductValue);
        /// <summary> A capability, skill, or expertise. </summary>
        public static EntityCategory Skill { get; } = new EntityCategory(SkillValue);
        /// <summary> Determines if two <see cref="EntityCategory"/> values are the same. </summary>
        public static bool operator ==(EntityCategory left, EntityCategory right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EntityCategory"/> values are not the same. </summary>
        public static bool operator !=(EntityCategory left, EntityCategory right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EntityCategory"/>. </summary>
        public static implicit operator EntityCategory(string value) => new EntityCategory(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EntityCategory other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EntityCategory other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
