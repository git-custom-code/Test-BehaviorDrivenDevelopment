﻿namespace CustomCode.Test.BehaviorDrivenDevelopment
{
    using System;
    using Xunit.Sdk;

    /// <summary>
    /// Define any number of assertions on a method result of type <typeparamref name="TResult"/>.
    /// </summary>
    /// <typeparam name="T"> The type under test. </typeparam>
    /// <typeparam name="TFirst"> The type of the first parameter needed for the method under test. </typeparam>
    /// <typeparam name="TSecond"> The type of the second parameter needed for the method under test. </typeparam>
    /// <typeparam name="TResult"> The type of the result of the method under test. </typeparam>
    public struct ValidatorWithTwoParameters<T, TFirst, TSecond, TResult> : IFluentInterface
        where TFirst: class
        where TSecond : class
    {
        #region Dependencies

        /// <summary>
        /// Create a new instance of the <see cref="ValidatorWithTwoParameters{T, TFirst, TSecond, TResult}"/> type.
        /// </summary>
        /// <param name="arrange"> A delegate that creates the type under test. </param>
        /// <param name="arrangeFirstParameter"> A delegate that creates the needed first parameter instance. </param>
        /// <param name="arrangeSecondParameter"> A delegate that creates the needed second parameter instance. </param>
        /// <param name="act"> A delegate that executes the (non-void) method under test. </param>
        public ValidatorWithTwoParameters(
            Func<T> arrange,
            Func<TFirst> arrangeFirstParameter,
            Func<TSecond> arrangeSecondParameter,
            Func<T, TFirst, TSecond, TResult> act)
        {
            Arrange = arrange ?? throw new XunitException($"The {nameof(arrange)} delegate cannot be null.");
            ArrangeFirstParameter = arrangeFirstParameter ?? throw new XunitException($"The {nameof(arrangeFirstParameter)} delegate cannot be null.");
            ArrangeSecondParameter = arrangeSecondParameter ?? throw new XunitException($"The {nameof(arrangeSecondParameter)} delegate cannot be null.");
            Act = act ?? throw new XunitException($"The {nameof(act)} delegate cannot be null.");
        }

        #endregion

        #region Data

        /// <summary>
        /// Gets a delegate that executes the (non-void) method under test.
        /// </summary>
        private Func<T, TFirst, TSecond, TResult> Act { get; }

        /// <summary>
        /// Gets a delegate that creates the type under test.
        /// </summary>
        private Func<T> Arrange { get; }

        /// <summary>
        /// Gets a delegate that creates the needed first parameter instance.
        /// </summary>
        private Func<TFirst> ArrangeFirstParameter { get; }

        /// <summary>
        /// Gets a delegate that creates the needed second parameter instance.
        /// </summary>
        private Func<TSecond> ArrangeSecondParameter { get; }

        #endregion

        #region Logic

        /// <summary>
        /// Define any number of assertions on the result of the method under test after it was
        /// successfully executed.
        /// </summary>
        /// <param name="assert">
        /// A delegate that is used to execute any number of assertions on the result of the method under test.
        /// </param>
        public void Then(Action<TResult> assert)
        {
            try
            {
                // given
                var typeUnderTest = Arrange();
                var firstParameter = ArrangeFirstParameter();
                var secondParameter = ArrangeSecondParameter();

                // when
                var result = Act(typeUnderTest, firstParameter, secondParameter);

                // then
                assert(result);
            }
            catch (Exception e)
            {
                // TODO
                throw e;
            }
        }

        /// <summary>
        /// Define any number of assertions on the thrown and expected exception of the method under test
        /// after it was executed.
        /// </summary>
        /// <typeparam name="TException"> The type of the exception that is thrown. </typeparam>
        /// <param name="assert">
        /// A delegate that is used to execute any number of assertions on the thrown exception of the method under test.
        /// </param>
        public void ThenThrow<TException>(Action<TException> assert = null)
            where TException : Exception
        {
            try
            {
                // given
                var typeUnderTest = Arrange();
                var firstParameter = ArrangeFirstParameter();
                var secondParameter = ArrangeSecondParameter();

                // when
                try
                {
                    Act(typeUnderTest, firstParameter, secondParameter);

                    var rn = Environment.NewLine;
                    var message = $"{rn}Expected exception of type {typeof(TException).Name}{rn}but no exception was thrown";
                    throw new XunitException(message);
                }
                catch (XunitException)
                {
                    throw;
                }
                catch (TException exception)
                {
                    // then
                    assert?.Invoke(exception);
                }
                catch (Exception exception)
                {
                    var rn = Environment.NewLine;
                    var message = $"{rn}Expected exception of type {typeof(TException).Name}{rn}but instead caught {exception.GetType().Name}";
                    throw new XunitException(message);
                }
            }
            catch (XunitException)
            {
                throw;
            }
            catch (Exception e)
            {
                // TODO
                throw e;
            }
        }

        #endregion
    }
}