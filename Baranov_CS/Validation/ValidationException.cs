using System;

namespace Baranov_CS.Validation {

    class ValidationException : Exception {

        public ValidationException() : base() {
        }

        public ValidationException(string message) : base(message) {

        }
    }
}
