// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Fixtures.XmsErrorResponses.Models
{
    using Microsoft.Rest;

    /// <summary>
    /// Exception thrown for an invalid response with PetSadError information.
    /// </summary>
    public partial class PetSadErrorException : RestException<PetSadError>
    {

        /// <summary>
        /// Initializes a new instance of the PetSadErrorException class.
        /// </summary>
        public PetSadErrorException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PetSadErrorException class.
        /// </summary>
        /// <param name="message">The exception message.</param>
        public PetSadErrorException(string message)
        : this(message, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PetSadErrorException class.
        /// </summary>
        /// <param name="message">The exception message.</param>
        /// <param name="innerException">Inner exception.</param>
        public PetSadErrorException(string message, System.Exception innerException)
        : base(message, innerException)
        {
        }

            /// <summary>
        /// Gets or sets why is the pet sad
        /// </summary>
        public string Reason
        {
            get
            {
                return Body?.Reason;
            }
        }

        /// <summary>
        /// Gets or sets the error message
        /// </summary>
        public string ErrorMessage
        {
            get
            {
                return Body?.ErrorMessage;
            }
        }

    }
}