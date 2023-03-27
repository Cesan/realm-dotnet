﻿// <auto-generated />
#nullable enable

using MongoDB.Bson;
using Realms;
using Realms.Schema;
using Realms.Tests;
using Realms.Tests.Database;
using Realms.Weaving;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using TestEmbeddedObject = Realms.IEmbeddedObject;
using TestRealmObject = Realms.IRealmObject;

namespace Realms.Tests
{
    [Generated]
    [Woven(typeof(SyncAllTypesObjectObjectHelper)), Realms.Preserve(AllMembers = true)]
    public partial class SyncAllTypesObject : IRealmObject, INotifyPropertyChanged, IReflectableType
    {
        /// <summary>
        /// Defines the schema for the <see cref="SyncAllTypesObject"/> class.
        /// </summary>
        public static Realms.Schema.ObjectSchema RealmSchema = new Realms.Schema.ObjectSchema.Builder("SyncAllTypesObject", ObjectSchema.ObjectType.RealmObject)
        {
            Realms.Schema.Property.Primitive("_id", Realms.RealmValueType.ObjectId, isPrimaryKey: true, isIndexed: false, isNullable: false, managedName: "Id"),
            Realms.Schema.Property.Primitive("CharProperty", Realms.RealmValueType.Int, isPrimaryKey: false, isIndexed: false, isNullable: false, managedName: "CharProperty"),
            Realms.Schema.Property.Primitive("ByteProperty", Realms.RealmValueType.Int, isPrimaryKey: false, isIndexed: false, isNullable: false, managedName: "ByteProperty"),
            Realms.Schema.Property.Primitive("Int16Property", Realms.RealmValueType.Int, isPrimaryKey: false, isIndexed: false, isNullable: false, managedName: "Int16Property"),
            Realms.Schema.Property.Primitive("Int32Property", Realms.RealmValueType.Int, isPrimaryKey: false, isIndexed: false, isNullable: false, managedName: "Int32Property"),
            Realms.Schema.Property.Primitive("Int64Property", Realms.RealmValueType.Int, isPrimaryKey: false, isIndexed: false, isNullable: false, managedName: "Int64Property"),
            Realms.Schema.Property.Primitive("FloatProperty", Realms.RealmValueType.Float, isPrimaryKey: false, isIndexed: false, isNullable: false, managedName: "FloatProperty"),
            Realms.Schema.Property.Primitive("DoubleProperty", Realms.RealmValueType.Double, isPrimaryKey: false, isIndexed: false, isNullable: false, managedName: "DoubleProperty"),
            Realms.Schema.Property.Primitive("BooleanProperty", Realms.RealmValueType.Bool, isPrimaryKey: false, isIndexed: false, isNullable: false, managedName: "BooleanProperty"),
            Realms.Schema.Property.Primitive("DateTimeOffsetProperty", Realms.RealmValueType.Date, isPrimaryKey: false, isIndexed: false, isNullable: false, managedName: "DateTimeOffsetProperty"),
            Realms.Schema.Property.Primitive("DecimalProperty", Realms.RealmValueType.Decimal128, isPrimaryKey: false, isIndexed: false, isNullable: false, managedName: "DecimalProperty"),
            Realms.Schema.Property.Primitive("Decimal128Property", Realms.RealmValueType.Decimal128, isPrimaryKey: false, isIndexed: false, isNullable: false, managedName: "Decimal128Property"),
            Realms.Schema.Property.Primitive("ObjectIdProperty", Realms.RealmValueType.ObjectId, isPrimaryKey: false, isIndexed: false, isNullable: false, managedName: "ObjectIdProperty"),
            Realms.Schema.Property.Primitive("GuidProperty", Realms.RealmValueType.Guid, isPrimaryKey: false, isIndexed: false, isNullable: false, managedName: "GuidProperty"),
            Realms.Schema.Property.Primitive("StringProperty", Realms.RealmValueType.String, isPrimaryKey: false, isIndexed: false, isNullable: true, managedName: "StringProperty"),
            Realms.Schema.Property.Primitive("ByteArrayProperty", Realms.RealmValueType.Data, isPrimaryKey: false, isIndexed: false, isNullable: true, managedName: "ByteArrayProperty"),
            Realms.Schema.Property.RealmValue("RealmValueProperty", managedName: "RealmValueProperty"),
            Realms.Schema.Property.Object("ObjectProperty", "IntPropertyObject", managedName: "ObjectProperty"),
            Realms.Schema.Property.Object("EmbeddedObjectProperty", "EmbeddedIntPropertyObject", managedName: "EmbeddedObjectProperty"),
        }.Build();

        #region IRealmObject implementation

        private ISyncAllTypesObjectAccessor? _accessor;

        Realms.IRealmAccessor Realms.IRealmObjectBase.Accessor => Accessor;

        internal ISyncAllTypesObjectAccessor Accessor => _accessor ??= new SyncAllTypesObjectUnmanagedAccessor(typeof(SyncAllTypesObject));

        /// <inheritdoc />
        [IgnoreDataMember, XmlIgnore]
        public bool IsManaged => Accessor.IsManaged;

        /// <inheritdoc />
        [IgnoreDataMember, XmlIgnore]
        public bool IsValid => Accessor.IsValid;

        /// <inheritdoc />
        [IgnoreDataMember, XmlIgnore]
        public bool IsFrozen => Accessor.IsFrozen;

        /// <inheritdoc />
        [IgnoreDataMember, XmlIgnore]
        public Realms.Realm? Realm => Accessor.Realm;

        /// <inheritdoc />
        [IgnoreDataMember, XmlIgnore]
        public Realms.Schema.ObjectSchema ObjectSchema => Accessor.ObjectSchema!;

        /// <inheritdoc />
        [IgnoreDataMember, XmlIgnore]
        public Realms.DynamicObjectApi DynamicApi => Accessor.DynamicApi;

        /// <inheritdoc />
        [IgnoreDataMember, XmlIgnore]
        public int BacklinksCount => Accessor.BacklinksCount;

        void ISettableManagedAccessor.SetManagedAccessor(Realms.IRealmAccessor managedAccessor, Realms.Weaving.IRealmObjectHelper? helper, bool update, bool skipDefaults)
        {
            var newAccessor = (ISyncAllTypesObjectAccessor)managedAccessor;
            var oldAccessor = _accessor;
            _accessor = newAccessor;

            if (helper != null && oldAccessor != null)
            {
                if (!skipDefaults || oldAccessor.Id != default(MongoDB.Bson.ObjectId))
                {
                    newAccessor.Id = oldAccessor.Id;
                }
                if (!skipDefaults || oldAccessor.CharProperty != default(char))
                {
                    newAccessor.CharProperty = oldAccessor.CharProperty;
                }
                if (!skipDefaults || oldAccessor.ByteProperty != default(byte))
                {
                    newAccessor.ByteProperty = oldAccessor.ByteProperty;
                }
                if (!skipDefaults || oldAccessor.Int16Property != default(short))
                {
                    newAccessor.Int16Property = oldAccessor.Int16Property;
                }
                if (!skipDefaults || oldAccessor.Int32Property != default(int))
                {
                    newAccessor.Int32Property = oldAccessor.Int32Property;
                }
                if (!skipDefaults || oldAccessor.Int64Property != default(long))
                {
                    newAccessor.Int64Property = oldAccessor.Int64Property;
                }
                if (!skipDefaults || oldAccessor.FloatProperty != default(float))
                {
                    newAccessor.FloatProperty = oldAccessor.FloatProperty;
                }
                if (!skipDefaults || oldAccessor.DoubleProperty != default(double))
                {
                    newAccessor.DoubleProperty = oldAccessor.DoubleProperty;
                }
                if (!skipDefaults || oldAccessor.BooleanProperty != default(bool))
                {
                    newAccessor.BooleanProperty = oldAccessor.BooleanProperty;
                }
                newAccessor.DateTimeOffsetProperty = oldAccessor.DateTimeOffsetProperty;
                if (!skipDefaults || oldAccessor.DecimalProperty != default(decimal))
                {
                    newAccessor.DecimalProperty = oldAccessor.DecimalProperty;
                }
                if (!skipDefaults || oldAccessor.Decimal128Property != default(MongoDB.Bson.Decimal128))
                {
                    newAccessor.Decimal128Property = oldAccessor.Decimal128Property;
                }
                if (!skipDefaults || oldAccessor.ObjectIdProperty != default(MongoDB.Bson.ObjectId))
                {
                    newAccessor.ObjectIdProperty = oldAccessor.ObjectIdProperty;
                }
                if (!skipDefaults || oldAccessor.GuidProperty != default(System.Guid))
                {
                    newAccessor.GuidProperty = oldAccessor.GuidProperty;
                }
                if (!skipDefaults || oldAccessor.StringProperty != default(string?))
                {
                    newAccessor.StringProperty = oldAccessor.StringProperty;
                }
                if (!skipDefaults || oldAccessor.ByteArrayProperty != default(byte[]?))
                {
                    newAccessor.ByteArrayProperty = oldAccessor.ByteArrayProperty;
                }
                newAccessor.RealmValueProperty = oldAccessor.RealmValueProperty;
                if (oldAccessor.ObjectProperty != null && newAccessor.Realm != null)
                {
                    newAccessor.Realm.Add(oldAccessor.ObjectProperty, update);
                }
                newAccessor.ObjectProperty = oldAccessor.ObjectProperty;
                newAccessor.EmbeddedObjectProperty = oldAccessor.EmbeddedObjectProperty;
            }

            if (_propertyChanged != null)
            {
                SubscribeForNotifications();
            }

            OnManaged();
        }

        #endregion

        /// <summary>
        /// Called when the object has been managed by a Realm.
        /// </summary>
        /// <remarks>
        /// This method will be called either when a managed object is materialized or when an unmanaged object has been
        /// added to the Realm. It can be useful for providing some initialization logic as when the constructor is invoked,
        /// it is not yet clear whether the object is managed or not.
        /// </remarks>
        partial void OnManaged();

        private event PropertyChangedEventHandler? _propertyChanged;

        /// <inheritdoc />
        public event PropertyChangedEventHandler? PropertyChanged
        {
            add
            {
                if (_propertyChanged == null)
                {
                    SubscribeForNotifications();
                }

                _propertyChanged += value;
            }

            remove
            {
                _propertyChanged -= value;

                if (_propertyChanged == null)
                {
                    UnsubscribeFromNotifications();
                }
            }
        }

        /// <summary>
        /// Called when a property has changed on this class.
        /// </summary>
        /// <param name="propertyName">The name of the property.</param>
        /// <remarks>
        /// For this method to be called, you need to have first subscribed to <see cref="PropertyChanged"/>.
        /// This can be used to react to changes to the current object, e.g. raising <see cref="PropertyChanged"/> for computed properties.
        /// </remarks>
        /// <example>
        /// <code>
        /// class MyClass : IRealmObject
        /// {
        ///     public int StatusCodeRaw { get; set; }
        ///     public StatusCodeEnum StatusCode => (StatusCodeEnum)StatusCodeRaw;
        ///     partial void OnPropertyChanged(string propertyName)
        ///     {
        ///         if (propertyName == nameof(StatusCodeRaw))
        ///         {
        ///             RaisePropertyChanged(nameof(StatusCode));
        ///         }
        ///     }
        /// }
        /// </code>
        /// Here, we have a computed property that depends on a persisted one. In order to notify any <see cref="PropertyChanged"/>
        /// subscribers that <c>StatusCode</c> has changed, we implement <see cref="OnPropertyChanged"/> and
        /// raise <see cref="PropertyChanged"/> manually by calling <see cref="RaisePropertyChanged"/>.
        /// </example>
        partial void OnPropertyChanged(string? propertyName);

        private void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            _propertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            OnPropertyChanged(propertyName);
        }

        private void SubscribeForNotifications()
        {
            Accessor.SubscribeForNotifications(RaisePropertyChanged);
        }

        private void UnsubscribeFromNotifications()
        {
            Accessor.UnsubscribeFromNotifications();
        }

        /// <summary>
        /// Converts a <see cref="Realms.RealmValue"/> to <see cref="SyncAllTypesObject"/>. Equivalent to <see cref="Realms.RealmValue.AsNullableRealmObject{T}"/>.
        /// </summary>
        /// <param name="val">The <see cref="Realms.RealmValue"/> to convert.</param>
        /// <returns>The <see cref="SyncAllTypesObject"/> stored in the <see cref="Realms.RealmValue"/>.</returns>
        public static explicit operator SyncAllTypesObject?(Realms.RealmValue val) => val.Type == Realms.RealmValueType.Null ? null : val.AsRealmObject<SyncAllTypesObject>();

        /// <summary>
        /// Implicitly constructs a <see cref="Realms.RealmValue"/> from <see cref="SyncAllTypesObject"/>.
        /// </summary>
        /// <param name="val">The value to store in the <see cref="Realms.RealmValue"/>.</param>
        /// <returns>A <see cref="Realms.RealmValue"/> containing the supplied <paramref name="val"/>.</returns>
        public static implicit operator Realms.RealmValue(SyncAllTypesObject? val) => val == null ? Realms.RealmValue.Null : Realms.RealmValue.Object(val);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public TypeInfo GetTypeInfo() => Accessor.GetTypeInfo(this);

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            if (obj is null)
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj is InvalidObject)
            {
                return !IsValid;
            }

            if (obj is not Realms.IRealmObjectBase iro)
            {
                return false;
            }

            return Accessor.Equals(iro.Accessor);
        }

        /// <inheritdoc />
        public override int GetHashCode() => IsManaged ? Accessor.GetHashCode() : base.GetHashCode();

        /// <inheritdoc />
        public override string? ToString() => Accessor.ToString();

        [EditorBrowsable(EditorBrowsableState.Never), Realms.Preserve(AllMembers = true)]
        private class SyncAllTypesObjectObjectHelper : Realms.Weaving.IRealmObjectHelper
        {
            public void CopyToRealm(Realms.IRealmObjectBase instance, bool update, bool skipDefaults)
            {
                throw new InvalidOperationException("This method should not be called for source generated classes.");
            }

            public Realms.ManagedAccessor CreateAccessor() => new SyncAllTypesObjectManagedAccessor();

            public Realms.IRealmObjectBase CreateInstance() => new SyncAllTypesObject();

            public bool TryGetPrimaryKeyValue(Realms.IRealmObjectBase instance, out RealmValue value)
            {
                value = ((ISyncAllTypesObjectAccessor)instance.Accessor).Id;
                return true;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never), Realms.Preserve(AllMembers = true)]
        internal interface ISyncAllTypesObjectAccessor : Realms.IRealmAccessor
        {
            MongoDB.Bson.ObjectId Id { get; set; }

            char CharProperty { get; set; }

            byte ByteProperty { get; set; }

            short Int16Property { get; set; }

            int Int32Property { get; set; }

            long Int64Property { get; set; }

            float FloatProperty { get; set; }

            double DoubleProperty { get; set; }

            bool BooleanProperty { get; set; }

            System.DateTimeOffset DateTimeOffsetProperty { get; set; }

            decimal DecimalProperty { get; set; }

            MongoDB.Bson.Decimal128 Decimal128Property { get; set; }

            MongoDB.Bson.ObjectId ObjectIdProperty { get; set; }

            System.Guid GuidProperty { get; set; }

            string? StringProperty { get; set; }

            byte[]? ByteArrayProperty { get; set; }

            Realms.RealmValue RealmValueProperty { get; set; }

            Realms.Tests.IntPropertyObject? ObjectProperty { get; set; }

            Realms.Tests.EmbeddedIntPropertyObject? EmbeddedObjectProperty { get; set; }
        }

        [EditorBrowsable(EditorBrowsableState.Never), Realms.Preserve(AllMembers = true)]
        internal class SyncAllTypesObjectManagedAccessor : Realms.ManagedAccessor, ISyncAllTypesObjectAccessor
        {
            public MongoDB.Bson.ObjectId Id
            {
                get => (MongoDB.Bson.ObjectId)GetValue("_id");
                set => SetValueUnique("_id", value);
            }

            public char CharProperty
            {
                get => (char)GetValue("CharProperty");
                set => SetValue("CharProperty", value);
            }

            public byte ByteProperty
            {
                get => (byte)GetValue("ByteProperty");
                set => SetValue("ByteProperty", value);
            }

            public short Int16Property
            {
                get => (short)GetValue("Int16Property");
                set => SetValue("Int16Property", value);
            }

            public int Int32Property
            {
                get => (int)GetValue("Int32Property");
                set => SetValue("Int32Property", value);
            }

            public long Int64Property
            {
                get => (long)GetValue("Int64Property");
                set => SetValue("Int64Property", value);
            }

            public float FloatProperty
            {
                get => (float)GetValue("FloatProperty");
                set => SetValue("FloatProperty", value);
            }

            public double DoubleProperty
            {
                get => (double)GetValue("DoubleProperty");
                set => SetValue("DoubleProperty", value);
            }

            public bool BooleanProperty
            {
                get => (bool)GetValue("BooleanProperty");
                set => SetValue("BooleanProperty", value);
            }

            public System.DateTimeOffset DateTimeOffsetProperty
            {
                get => (System.DateTimeOffset)GetValue("DateTimeOffsetProperty");
                set => SetValue("DateTimeOffsetProperty", value);
            }

            public decimal DecimalProperty
            {
                get => (decimal)GetValue("DecimalProperty");
                set => SetValue("DecimalProperty", value);
            }

            public MongoDB.Bson.Decimal128 Decimal128Property
            {
                get => (MongoDB.Bson.Decimal128)GetValue("Decimal128Property");
                set => SetValue("Decimal128Property", value);
            }

            public MongoDB.Bson.ObjectId ObjectIdProperty
            {
                get => (MongoDB.Bson.ObjectId)GetValue("ObjectIdProperty");
                set => SetValue("ObjectIdProperty", value);
            }

            public System.Guid GuidProperty
            {
                get => (System.Guid)GetValue("GuidProperty");
                set => SetValue("GuidProperty", value);
            }

            public string? StringProperty
            {
                get => (string?)GetValue("StringProperty");
                set => SetValue("StringProperty", value);
            }

            public byte[]? ByteArrayProperty
            {
                get => (byte[]?)GetValue("ByteArrayProperty");
                set => SetValue("ByteArrayProperty", value);
            }

            public Realms.RealmValue RealmValueProperty
            {
                get => (Realms.RealmValue)GetValue("RealmValueProperty");
                set => SetValue("RealmValueProperty", value);
            }

            public Realms.Tests.IntPropertyObject? ObjectProperty
            {
                get => (Realms.Tests.IntPropertyObject?)GetValue("ObjectProperty");
                set => SetValue("ObjectProperty", value);
            }

            public Realms.Tests.EmbeddedIntPropertyObject? EmbeddedObjectProperty
            {
                get => (Realms.Tests.EmbeddedIntPropertyObject?)GetValue("EmbeddedObjectProperty");
                set => SetValue("EmbeddedObjectProperty", value);
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never), Realms.Preserve(AllMembers = true)]
        internal class SyncAllTypesObjectUnmanagedAccessor : Realms.UnmanagedAccessor, ISyncAllTypesObjectAccessor
        {
            public override ObjectSchema ObjectSchema => SyncAllTypesObject.RealmSchema;

            private MongoDB.Bson.ObjectId _id = ObjectId.GenerateNewId();
            public MongoDB.Bson.ObjectId Id
            {
                get => _id;
                set
                {
                    _id = value;
                    RaisePropertyChanged("Id");
                }
            }

            private char _charProperty;
            public char CharProperty
            {
                get => _charProperty;
                set
                {
                    _charProperty = value;
                    RaisePropertyChanged("CharProperty");
                }
            }

            private byte _byteProperty;
            public byte ByteProperty
            {
                get => _byteProperty;
                set
                {
                    _byteProperty = value;
                    RaisePropertyChanged("ByteProperty");
                }
            }

            private short _int16Property;
            public short Int16Property
            {
                get => _int16Property;
                set
                {
                    _int16Property = value;
                    RaisePropertyChanged("Int16Property");
                }
            }

            private int _int32Property;
            public int Int32Property
            {
                get => _int32Property;
                set
                {
                    _int32Property = value;
                    RaisePropertyChanged("Int32Property");
                }
            }

            private long _int64Property;
            public long Int64Property
            {
                get => _int64Property;
                set
                {
                    _int64Property = value;
                    RaisePropertyChanged("Int64Property");
                }
            }

            private float _floatProperty;
            public float FloatProperty
            {
                get => _floatProperty;
                set
                {
                    _floatProperty = value;
                    RaisePropertyChanged("FloatProperty");
                }
            }

            private double _doubleProperty;
            public double DoubleProperty
            {
                get => _doubleProperty;
                set
                {
                    _doubleProperty = value;
                    RaisePropertyChanged("DoubleProperty");
                }
            }

            private bool _booleanProperty;
            public bool BooleanProperty
            {
                get => _booleanProperty;
                set
                {
                    _booleanProperty = value;
                    RaisePropertyChanged("BooleanProperty");
                }
            }

            private System.DateTimeOffset _dateTimeOffsetProperty;
            public System.DateTimeOffset DateTimeOffsetProperty
            {
                get => _dateTimeOffsetProperty;
                set
                {
                    _dateTimeOffsetProperty = value;
                    RaisePropertyChanged("DateTimeOffsetProperty");
                }
            }

            private decimal _decimalProperty;
            public decimal DecimalProperty
            {
                get => _decimalProperty;
                set
                {
                    _decimalProperty = value;
                    RaisePropertyChanged("DecimalProperty");
                }
            }

            private MongoDB.Bson.Decimal128 _decimal128Property;
            public MongoDB.Bson.Decimal128 Decimal128Property
            {
                get => _decimal128Property;
                set
                {
                    _decimal128Property = value;
                    RaisePropertyChanged("Decimal128Property");
                }
            }

            private MongoDB.Bson.ObjectId _objectIdProperty;
            public MongoDB.Bson.ObjectId ObjectIdProperty
            {
                get => _objectIdProperty;
                set
                {
                    _objectIdProperty = value;
                    RaisePropertyChanged("ObjectIdProperty");
                }
            }

            private System.Guid _guidProperty;
            public System.Guid GuidProperty
            {
                get => _guidProperty;
                set
                {
                    _guidProperty = value;
                    RaisePropertyChanged("GuidProperty");
                }
            }

            private string? _stringProperty;
            public string? StringProperty
            {
                get => _stringProperty;
                set
                {
                    _stringProperty = value;
                    RaisePropertyChanged("StringProperty");
                }
            }

            private byte[]? _byteArrayProperty;
            public byte[]? ByteArrayProperty
            {
                get => _byteArrayProperty;
                set
                {
                    _byteArrayProperty = value;
                    RaisePropertyChanged("ByteArrayProperty");
                }
            }

            private Realms.RealmValue _realmValueProperty;
            public Realms.RealmValue RealmValueProperty
            {
                get => _realmValueProperty;
                set
                {
                    _realmValueProperty = value;
                    RaisePropertyChanged("RealmValueProperty");
                }
            }

            private Realms.Tests.IntPropertyObject? _objectProperty;
            public Realms.Tests.IntPropertyObject? ObjectProperty
            {
                get => _objectProperty;
                set
                {
                    _objectProperty = value;
                    RaisePropertyChanged("ObjectProperty");
                }
            }

            private Realms.Tests.EmbeddedIntPropertyObject? _embeddedObjectProperty;
            public Realms.Tests.EmbeddedIntPropertyObject? EmbeddedObjectProperty
            {
                get => _embeddedObjectProperty;
                set
                {
                    _embeddedObjectProperty = value;
                    RaisePropertyChanged("EmbeddedObjectProperty");
                }
            }

            public SyncAllTypesObjectUnmanagedAccessor(Type objectType) : base(objectType)
            {
            }

            public override Realms.RealmValue GetValue(string propertyName)
            {
                return propertyName switch
                {
                    "_id" => _id,
                    "CharProperty" => _charProperty,
                    "ByteProperty" => _byteProperty,
                    "Int16Property" => _int16Property,
                    "Int32Property" => _int32Property,
                    "Int64Property" => _int64Property,
                    "FloatProperty" => _floatProperty,
                    "DoubleProperty" => _doubleProperty,
                    "BooleanProperty" => _booleanProperty,
                    "DateTimeOffsetProperty" => _dateTimeOffsetProperty,
                    "DecimalProperty" => _decimalProperty,
                    "Decimal128Property" => _decimal128Property,
                    "ObjectIdProperty" => _objectIdProperty,
                    "GuidProperty" => _guidProperty,
                    "StringProperty" => _stringProperty,
                    "ByteArrayProperty" => _byteArrayProperty,
                    "RealmValueProperty" => _realmValueProperty,
                    "ObjectProperty" => _objectProperty,
                    "EmbeddedObjectProperty" => _embeddedObjectProperty,
                    _ => throw new MissingMemberException($"The object does not have a gettable Realm property with name {propertyName}"),
                };
            }

            public override void SetValue(string propertyName, Realms.RealmValue val)
            {
                switch (propertyName)
                {
                    case "_id":
                        throw new InvalidOperationException("Cannot set the value of a primary key property with SetValue. You need to use SetValueUnique");
                    case "CharProperty":
                        CharProperty = (char)val;
                        return;
                    case "ByteProperty":
                        ByteProperty = (byte)val;
                        return;
                    case "Int16Property":
                        Int16Property = (short)val;
                        return;
                    case "Int32Property":
                        Int32Property = (int)val;
                        return;
                    case "Int64Property":
                        Int64Property = (long)val;
                        return;
                    case "FloatProperty":
                        FloatProperty = (float)val;
                        return;
                    case "DoubleProperty":
                        DoubleProperty = (double)val;
                        return;
                    case "BooleanProperty":
                        BooleanProperty = (bool)val;
                        return;
                    case "DateTimeOffsetProperty":
                        DateTimeOffsetProperty = (System.DateTimeOffset)val;
                        return;
                    case "DecimalProperty":
                        DecimalProperty = (decimal)val;
                        return;
                    case "Decimal128Property":
                        Decimal128Property = (MongoDB.Bson.Decimal128)val;
                        return;
                    case "ObjectIdProperty":
                        ObjectIdProperty = (MongoDB.Bson.ObjectId)val;
                        return;
                    case "GuidProperty":
                        GuidProperty = (System.Guid)val;
                        return;
                    case "StringProperty":
                        StringProperty = (string?)val;
                        return;
                    case "ByteArrayProperty":
                        ByteArrayProperty = (byte[]?)val;
                        return;
                    case "RealmValueProperty":
                        RealmValueProperty = (Realms.RealmValue)val;
                        return;
                    case "ObjectProperty":
                        ObjectProperty = (Realms.Tests.IntPropertyObject?)val;
                        return;
                    case "EmbeddedObjectProperty":
                        EmbeddedObjectProperty = (Realms.Tests.EmbeddedIntPropertyObject?)val;
                        return;
                    default:
                        throw new MissingMemberException($"The object does not have a settable Realm property with name {propertyName}");
                }
            }

            public override void SetValueUnique(string propertyName, Realms.RealmValue val)
            {
                if (propertyName != "_id")
                {
                    throw new InvalidOperationException($"Cannot set the value of non primary key property ({propertyName}) with SetValueUnique");
                }

                Id = (MongoDB.Bson.ObjectId)val;
            }

            public override IList<T> GetListValue<T>(string propertyName)
            {
                throw new MissingMemberException($"The object does not have a Realm list property with name {propertyName}");
            }

            public override ISet<T> GetSetValue<T>(string propertyName)
            {
                throw new MissingMemberException($"The object does not have a Realm set property with name {propertyName}");
            }

            public override IDictionary<string, TValue> GetDictionaryValue<TValue>(string propertyName)
            {
                throw new MissingMemberException($"The object does not have a Realm dictionary property with name {propertyName}");
            }
        }
    }
}
