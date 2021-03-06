﻿namespace CustomCode.Test.BehaviorDrivenDevelopment
{
    using System.Runtime.CompilerServices;

    /// <summary>
    /// A validator that defines assertions for nullable data types.
    /// </summary>
    public struct NullableValidator<T> : IFluentInterface where T : struct
    {
        #region Dependencies

        /// <summary>
        /// Creates a new instance of the <see cref="NullableValidator{T}"/> type.
        /// </summary>
        /// <param name="value"> The nullable value to be validated. </param>
        public NullableValidator(T? value)
        {
            Context = new ValidationContext<T?>();
            Value = value;
        }

        #endregion

        #region Data

        /// <summary>
        /// Gets the validation context.
        /// </summary>
        private ValidationContext<T?> Context { get; }

        /// <summary>
        /// Gets the nullable value to be validated.
        /// </summary>
        private T? Value { get; }

        #endregion

        #region Logic

        /// <summary>
        /// Assert that a given nullable value is null.
        /// </summary>
        /// <param name="because"> A reason why this assertion needs to be correct. </param>
        /// <param name="testMethodName"> Supplied by the compiler. </param>
        /// <param name="lineNumber"> Supplied by the compiler. </param>
        /// <param name="sourceCodePath"> Supplied by the compiler. </param>
        public void BeNull(string because = null,
            [CallerMemberName] string testMethodName = null, [CallerLineNumber] int lineNumber = 0, [CallerFilePath] string sourceCodePath = null)
        {
            if (Value.HasValue)
            {
                var context = Context.GetCallerContext(testMethodName, null, sourceCodePath, lineNumber);
                throw Context.GetFormattedException(testMethodName, context, $"is \"{Value}\"", $"to be null", because);
            }
        }

        #endregion
    }
}