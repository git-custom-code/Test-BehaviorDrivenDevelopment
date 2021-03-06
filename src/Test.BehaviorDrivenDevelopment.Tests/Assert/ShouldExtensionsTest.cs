﻿namespace CustomCode.Test.BehaviorDrivenDevelopment.Tests
{
    using System;
    using System.Linq;
    using System.Text;
    using Xunit;

    /// <summary>
    /// Test cases for the <see cref="ShouldExtensions"/> type.
    /// </summary>
    [UnitTest]
    [Category("Assert")]
    public sealed class ShouldExtensionsTest
    {
        #region bool

        [Fact(DisplayName = "bool.Should()")]
        [Category("Should")]
        public void UseShouldExtensionWithBooleans()
        {
            // Given
            var boolean = true;

            // When
            var validator = boolean.Should();

            // Then
            Assert.IsType<BoolValidator>(validator);
        }

        [Fact(DisplayName = "bool.ShouldNot()")]
        [Category("ShouldNot")]
        public void UseShouldNotExtensionWithBooleans()
        {
            // Given
            var boolean = true;

            // When
            var validator = boolean.ShouldNot();

            // Then
            Assert.IsType<BoolInverseValidator>(validator);
        }

        [Fact(DisplayName = "bool?.Should()")]
        [Category("Should")]
        public void UseShouldExtensionWithNullableBooleans()
        {
            // Given
            bool? boolean = true;

            // When
            var validator = boolean.Should();

            // Then
            Assert.IsType<NullableBoolValidator>(validator);
        }

        [Fact(DisplayName = "bool?.ShouldNot()")]
        [Category("ShouldNot")]
        public void UseShouldNotExtensionWithNullableBooleans()
        {
            // Given
            bool? boolean = true;

            // When
            var validator = boolean.ShouldNot();

            // Then
            Assert.IsType<NullableBoolInverseValidator>(validator);
        }

        #endregion

        #region byte

        [Fact(DisplayName = "byte.Should()")]
        [Category("Should")]
        public void UseShouldExtensionWithBytes()
        {
            // Given
            byte @byte = 42;

            // When
            var validator = @byte.Should();

            // Then
            Assert.IsType<ByteValidator>(validator);
        }

        [Fact(DisplayName = "byte.ShouldNot()")]
        [Category("ShouldNot")]
        public void UseShouldNotExtensionWithBytes()
        {
            // Given
            byte @byte = 42;

            // When
            var validator = @byte.ShouldNot();

            // Then
            Assert.IsType<ByteInverseValidator>(validator);
        }

        [Fact(DisplayName = "byte?.Should()")]
        [Category("Should")]
        public void UseShouldExtensionWithNullableBytes()
        {
            // Given
            byte? @byte = 42;

            // When
            var validator = @byte.Should();

            // Then
            Assert.IsType<NullableByteValidator>(validator);
        }

        [Fact(DisplayName = "byte?.ShouldNot()")]
        [Category("ShouldNot")]
        public void UseShouldNotExtensionWithNullableBytes()
        {
            // Given
            byte? @byte = 42;

            // When
            var validator = @byte.ShouldNot();

            // Then
            Assert.IsType<NullableByteInverseValidator>(validator);
        }

        #endregion

        #region decimal

        [Fact(DisplayName = "decimal.Should()")]
        [Category("Should")]
        public void UseShouldExtensionWithDecimals()
        {
            // Given
            var @decimal = 42m;

            // When
            var validator = @decimal.Should();

            // Then
            Assert.IsType<DecimalValidator>(validator);
        }

        [Fact(DisplayName = "decimal.ShouldNot()")]
        [Category("ShouldNot")]
        public void UseShouldNotExtensionWithDecimals()
        {
            // Given
            var @decimal = 42m;

            // When
            var validator = @decimal.ShouldNot();

            // Then
            Assert.IsType<DecimalInverseValidator>(validator);
        }

        [Fact(DisplayName = "decimal?.Should()")]
        [Category("Should")]
        public void UseShouldExtensionWithNullableDecimals()
        {
            // Given
            decimal? @decimal = 42m;

            // When
            var validator = @decimal.Should();

            // Then
            Assert.IsType<NullableDecimalValidator>(validator);
        }

        [Fact(DisplayName = "decimal?.ShouldNot()")]
        [Category("ShouldNot")]
        public void UseShouldNotExtensionWithNullableDecimals()
        {
            // Given
            decimal? @decimal = 42m;

            // When
            var validator = @decimal.ShouldNot();

            // Then
            Assert.IsType<NullableDecimalInverseValidator>(validator);
        }

        #endregion

        #region double

        [Fact(DisplayName = "double.Should()")]
        [Category("Should")]
        public void UseShouldExtensionWithDoubles()
        {
            // Given
            var @double = 42d;

            // When
            var validator = @double.Should();

            // Then
            Assert.IsType<DoubleValidator>(validator);
        }

        [Fact(DisplayName = "double.ShouldNot()")]
        [Category("ShouldNot")]
        public void UseShouldNotExtensionWithDoubles()
        {
            // Given
            var @double = 42d;

            // When
            var validator = @double.ShouldNot();

            // Then
            Assert.IsType<DoubleInverseValidator>(validator);
        }

        [Fact(DisplayName = "double?.Should()")]
        [Category("Should")]
        public void UseShouldExtensionWithNullableDoubles()
        {
            // Given
            double? @double = 42d;

            // When
            var validator = @double.Should();

            // Then
            Assert.IsType<NullableDoubleValidator>(validator);
        }

        [Fact(DisplayName = "double?.ShouldNot()")]
        [Category("ShouldNot")]
        public void UseShouldNotExtensionWithNullableDoubles()
        {
            // Given
            double? @double = 42d;

            // When
            var validator = @double.ShouldNot();

            // Then
            Assert.IsType<NullableDoubleInverseValidator>(validator);
        }

        #endregion

        #region enum

        [Fact(DisplayName = "enum.Should()")]
        [Category("Should")]
        public void UseShouldExtensionWithEnums()
        {
            // Given
            var @enum = StringComparison.Ordinal;

            // When
            var validator = @enum.Should();

            // Then
            Assert.IsType<EnumValidator<StringComparison>>(validator);
        }

        [Fact(DisplayName = "enum.ShouldNot()")]
        [Category("ShouldNot")]
        public void UseShouldNotExtensionWithEnums()
        {
            // Given
            var @enum = StringComparison.Ordinal;

            // When
            var validator = @enum.ShouldNot();

            // Then
            Assert.IsType<EnumInverseValidator<StringComparison>>(validator);
        }

        #endregion

        #region float

        [Fact(DisplayName = "float.Should()")]
        [Category("Should")]
        public void UseShouldExtensionWithFloats()
        {
            // Given
            var @float = 42f;

            // When
            var validator = @float.Should();

            // Then
            Assert.IsType<FloatValidator>(validator);
        }

        [Fact(DisplayName = "float.ShouldNot()")]
        [Category("ShouldNot")]
        public void UseShouldNotExtensionWithFloats()
        {
            // Given
            var @float = 42f;

            // When
            var validator = @float.ShouldNot();

            // Then
            Assert.IsType<FloatInverseValidator>(validator);
        }

        [Fact(DisplayName = "float?.Should()")]
        [Category("Should")]
        public void UseShouldExtensionWithNullableFloats()
        {
            // Given
            float? @float = 42f;

            // When
            var validator = @float.Should();

            // Then
            Assert.IsType<NullableFloatValidator>(validator);
        }

        [Fact(DisplayName = "float?.ShouldNot()")]
        [Category("ShouldNot")]
        public void UseShouldNotExtensionWithNullableFloats()
        {
            // Given
            float? @float = 42f;

            // When
            var validator = @float.ShouldNot();

            // Then
            Assert.IsType<NullableFloatInverseValidator>(validator);
        }

        #endregion

        #region guid

        [Fact(DisplayName = "guid.Should()")]
        [Category("Should")]
        public void UseShouldExtensionWithGuids()
        {
            // Given
            var guid = Guid.Empty;

            // When
            var validator = guid.Should();

            // Then
            Assert.IsType<GuidValidator>(validator);
        }

        [Fact(DisplayName = "guid.ShouldNot()")]
        [Category("ShouldNot")]
        public void UseShouldNotExtensionWithGuids()
        {
            // Given
            var guid = Guid.Empty;

            // When
            var validator = guid.ShouldNot();

            // Then
            Assert.IsType<GuidInverseValidator>(validator);
        }

        [Fact(DisplayName = "guid?.Should()")]
        [Category("Should")]
        public void UseShouldExtensionWithNullableGuids()
        {
            // Given
            Guid? guid = Guid.Empty;

            // When
            var validator = guid.Should();

            // Then
            Assert.IsType<NullableGuidValidator>(validator);
        }

        [Fact(DisplayName = "guid?.ShouldNot()")]
        [Category("ShouldNot")]
        public void UseShouldNotExtensionWithNullableGuids()
        {
            // Given
            Guid? guid = Guid.Empty;

            // When
            var validator = guid.ShouldNot();

            // Then
            Assert.IsType<NullableGuidInverseValidator>(validator);
        }

        #endregion

        #region ienumerable

        [Fact(DisplayName = "ienumerable.Should()")]
        [Category("Should")]
        public void UseShouldExtensionWithIEnumerables()
        {
            // Given
            var enumerable = Enumerable.Empty<int>();

            // When
            var validator = enumerable.Should();

            // Then
            Assert.IsType<EnumerableValidator<int>>(validator);
        }

        [Fact(DisplayName = "ienumerable.ShouldNot()")]
        [Category("ShouldNot")]
        public void UseShouldNotExtensionWithIEnumerables()
        {
            // Given
            var enumerable = Enumerable.Empty<int>();

            // When
            var validator = enumerable.ShouldNot();

            // Then
            Assert.IsType<EnumerableInverseValidator<int>>(validator);
        }

        #endregion

        #region int

        [Fact(DisplayName = "int.Should()")]
        [Category("Should")]
        public void UseShouldExtensionWithIntegers()
        {
            // Given
            var integer = 42;

            // When
            var validator = integer.Should();

            // Then
            Assert.IsType<IntValidator>(validator);
        }

        [Fact(DisplayName = "int.ShouldNot()")]
        [Category("ShouldNot")]
        public void UseShouldNotExtensionWithIntegers()
        {
            // Given
            var integer = 42;

            // When
            var validator = integer.ShouldNot();

            // Then
            Assert.IsType<IntInverseValidator>(validator);
        }

        [Fact(DisplayName = "int?.Should()")]
        [Category("Should")]
        public void UseShouldExtensionWithNullableIntegers()
        {
            // Given
            int? integer = 42;

            // When
            var validator = integer.Should();

            // Then
            Assert.IsType<NullableIntValidator>(validator);
        }

        [Fact(DisplayName = "int?.ShouldNot()")]
        [Category("ShouldNot")]
        public void UseShouldNotExtensionWithNullableIntegers()
        {
            // Given
            int? integer = 42;

            // When
            var validator = integer.ShouldNot();

            // Then
            Assert.IsType<NullableIntInverseValidator>(validator);
        }

        #endregion

        #region long

        [Fact(DisplayName = "long.Should()")]
        [Category("Should")]
        public void UseShouldExtensionWithLongs()
        {
            // Given
            long @long = 42;

            // When
            var validator = @long.Should();

            // Then
            Assert.IsType<LongValidator>(validator);
        }

        [Fact(DisplayName = "long.ShouldNot()")]
        [Category("ShouldNot")]
        public void UseShouldNotExtensionWithLongs()
        {
            // Given
            long @long = 42;

            // When
            var validator = @long.ShouldNot();

            // Then
            Assert.IsType<LongInverseValidator>(validator);
        }

        [Fact(DisplayName = "long?.Should()")]
        [Category("Should")]
        public void UseShouldExtensionWithNullableLongs()
        {
            // Given
            long? @long = 42;

            // When
            var validator = @long.Should();

            // Then
            Assert.IsType<NullableLongValidator>(validator);
        }

        [Fact(DisplayName = "long?.ShouldNot()")]
        [Category("ShouldNot")]
        public void UseShouldNotExtensionWithNullableLongs()
        {
            // Given
            long? @long = 42;

            // When
            var validator = @long.ShouldNot();

            // Then
            Assert.IsType<NullableLongInverseValidator>(validator);
        }

        #endregion

        #region nullable

        [Fact(DisplayName = "Nullable.Should()")]
        [Category("Should")]
        public void UseShouldExtensionWithNullables()
        {
            // Given
            int? @int = null;

            // When
            var intValidator = @int.Should<int>();

            // Then
            Assert.IsType<NullableValidator<int>>(intValidator);
        }

        [Fact(DisplayName = "Nullable.ShouldNot()")]
        [Category("ShouldNot")]
        public void UseShouldNotExtensionWithNullables()
        {
            // Given
            int? @int = null;

            // When
            var intValidator = @int.ShouldNot<int>();

            // Then
            Assert.IsType<NullableInverseValidator<int>>(intValidator);
        }

        #endregion

        #region objects

        [Fact(DisplayName = "object.Should()")]
        [Category("Should")]
        public void UseShouldExtensionWithObjects()
        {
            // Given
            var @object = new object();
            
            // When
            var objectValidator = @object.Should();
            
            // Then
            Assert.IsType<ReferenceTypeValidator<object>>(objectValidator);
        }

        [Fact(DisplayName = "object.ShouldNot()")]
        [Category("ShouldNot")]
        public void UseShouldNotExtensionWithObjects()
        {
            // Given
            var @object = new object();
            
            // When
            var objectValidator = @object.ShouldNot();
            
            // Then
            Assert.IsType<ReferenceTypeInverseValidator<object>>(objectValidator);
        }

        #endregion

        #region sbyte

        [Fact(DisplayName = "sbyte.Should()")]
        [Category("Should")]
        public void UseShouldExtensionWithSBytes()
        {
            // Given
            sbyte @byte = 42;

            // When
            var validator = @byte.Should();

            // Then
            Assert.IsType<SbyteValidator>(validator);
        }

        [Fact(DisplayName = "sbyte.ShouldNot()")]
        [Category("ShouldNot")]
        public void UseShouldNotExtensionWithSBytes()
        {
            // Given
            sbyte @byte = 42;

            // When
            var validator = @byte.ShouldNot();

            // Then
            Assert.IsType<SbyteInverseValidator>(validator);
        }

        [Fact(DisplayName = "sbyte?.Should()")]
        [Category("Should")]
        public void UseShouldExtensionWithNullableSBytes()
        {
            // Given
            sbyte? @byte = 42;

            // When
            var validator = @byte.Should();

            // Then
            Assert.IsType<NullableSbyteValidator>(validator);
        }

        [Fact(DisplayName = "sbyte?.ShouldNot()")]
        [Category("ShouldNot")]
        public void UseShouldNotExtensionWithNullableSBytes()
        {
            // Given
            sbyte? @byte = 42;

            // When
            var validator = @byte.ShouldNot();

            // Then
            Assert.IsType<NullableSbyteInverseValidator>(validator);
        }

        #endregion

        #region short

        [Fact(DisplayName = "short.Should()")]
        [Category("Should")]
        public void UseShouldExtensionWithShorts()
        {
            // Given
            short @short = 42;

            // When
            var validator = @short.Should();

            // Then
            Assert.IsType<ShortValidator>(validator);
        }

        [Fact(DisplayName = "short.ShouldNot()")]
        [Category("ShouldNot")]
        public void UseShouldNotExtensionWithShorts()
        {
            // Given
            short @short = 42;

            // When
            var validator = @short.ShouldNot();

            // Then
            Assert.IsType<ShortInverseValidator>(validator);
        }

        [Fact(DisplayName = "short?.Should()")]
        [Category("Should")]
        public void UseShouldExtensionWithNullableShorts()
        {
            // Given
            short? @short = 42;

            // When
            var validator = @short.Should();

            // Then
            Assert.IsType<NullableShortValidator>(validator);
        }

        [Fact(DisplayName = "short?.ShouldNot()")]
        [Category("ShouldNot")]
        public void UseShouldNotExtensionWithNullableShorts()
        {
            // Given
            short? @short = 42;

            // When
            var validator = @short.ShouldNot();

            // Then
            Assert.IsType<NullableShortInverseValidator>(validator);
        }

        #endregion

        #region string

        [Fact(DisplayName = "string.Should()")]
        [Category("Should")]
        public void UseShouldExtensionWithStrings()
        {
            // Given
            var @string = "string";

            // When
            var validator = @string.Should();

            // Then
            Assert.IsType<StringValidator>(validator);
        }

        [Fact(DisplayName = "string.ShouldNot()")]
        [Category("ShouldNot")]
        public void UseShouldNotExtensionWithStrings()
        {
            // Given
            var @string = "string";

            // When
            var validator = @string.ShouldNot();

            // Then
            Assert.IsType<StringInverseValidator>(validator);
        }

        #endregion

        #region uint

        [Fact(DisplayName = "uint.Should()")]
        [Category("Should")]
        public void UseShouldExtensionWithUInts()
        {
            // Given
            uint @int = 42;

            // When
            var validator = @int.Should();

            // Then
            Assert.IsType<UintValidator>(validator);
        }

        [Fact(DisplayName = "uint.ShouldNot()")]
        [Category("ShouldNot")]
        public void UseShouldNotExtensionWithUInts()
        {
            // Given
            uint @int = 42;

            // When
            var validator = @int.ShouldNot();

            // Then
            Assert.IsType<UintInverseValidator>(validator);
        }

        [Fact(DisplayName = "uint?.Should()")]
        [Category("Should")]
        public void UseShouldExtensionWithNullableUInts()
        {
            // Given
            uint? @int = 42;

            // When
            var validator = @int.Should();

            // Then
            Assert.IsType<NullableUintValidator>(validator);
        }

        [Fact(DisplayName = "uint?.ShouldNot()")]
        [Category("ShouldNot")]
        public void UseShouldNotExtensionWithNullableUInts()
        {
            // Given
            uint? @int = 42;

            // When
            var validator = @int.ShouldNot();

            // Then
            Assert.IsType<NullableUintInverseValidator>(validator);
        }

        #endregion

        #region ulong

        [Fact(DisplayName = "ulong.Should()")]
        [Category("Should")]
        public void UseShouldExtensionWithULongs()
        {
            // Given
            ulong @long = 42;

            // When
            var validator = @long.Should();

            // Then
            Assert.IsType<UlongValidator>(validator);
        }

        [Fact(DisplayName = "ulong.ShouldNot()")]
        [Category("ShouldNot")]
        public void UseShouldNotExtensionWithULongs()
        {
            // Given
            ulong @long = 42;

            // When
            var validator = @long.ShouldNot();

            // Then
            Assert.IsType<UlongInverseValidator>(validator);
        }

        [Fact(DisplayName = "ulong?.Should()")]
        [Category("Should")]
        public void UseShouldExtensionWithNullableULongs()
        {
            // Given
            ulong? @long = 42;

            // When
            var validator = @long.Should();

            // Then
            Assert.IsType<NullableUlongValidator>(validator);
        }

        [Fact(DisplayName = "ulong?.ShouldNot()")]
        [Category("ShouldNot")]
        public void UseShouldNotExtensionWithNullableULongs()
        {
            // Given
            ulong? @long = 42;

            // When
            var validator = @long.ShouldNot();

            // Then
            Assert.IsType<NullableUlongInverseValidator>(validator);
        }

        #endregion

        #region ushort

        [Fact(DisplayName = "ushort.Should()")]
        [Category("Should")]
        public void UseShouldExtensionWithUShorts()
        {
            // Given
            ushort @short = 42;

            // When
            var validator = @short.Should();

            // Then
            Assert.IsType<UshortValidator>(validator);
        }

        [Fact(DisplayName = "ushort.ShouldNot()")]
        [Category("ShouldNot")]
        public void UseShouldNotExtensionWithUShorts()
        {
            // Given
            ushort @short = 42;

            // When
            var validator = @short.ShouldNot();

            // Then
            Assert.IsType<UshortInverseValidator>(validator);
        }

        [Fact(DisplayName = "ushort?.Should()")]
        [Category("Should")]
        public void UseShouldExtensionWithNullableUShorts()
        {
            // Given
            ushort? @short = 42;

            // When
            var validator = @short.Should();

            // Then
            Assert.IsType<NullableUshortValidator>(validator);
        }

        [Fact(DisplayName = "ushort?.ShouldNot()")]
        [Category("ShouldNot")]
        public void UseShouldNotExtensionWithNullableUShorts()
        {
            // Given
            ushort? @short = 42;

            // When
            var validator = @short.ShouldNot();

            // Then
            Assert.IsType<NullableUshortInverseValidator>(validator);
        }

        #endregion
    }
}