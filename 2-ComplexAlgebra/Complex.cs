namespace ComplexAlgebra
{
    using System;
    /// <summary>
    /// A type for representing Complex numbers.
    /// </summary>
    ///
    /// TODO: Model Complex numbers in an object-oriented way and implement this class.
    /// TODO: In other words, you must provide a means for:
    /// TODO: * instantiating complex numbers
    /// TODO: * accessing a complex number's real, and imaginary parts
    /// TODO: * accessing a complex number's modulus, and phase
    /// TODO: * complementing a complex number
    /// TODO: * summing up or subtracting two complex numbers
    /// TODO: * representing a complex number as a string or the form Re +/- iIm
    /// TODO:     - e.g. via the ToString() method
    /// TODO: * checking whether two complex numbers are equal or not
    /// TODO:     - e.g. via the Equals(object) method
    public class Complex
    {
        // TODO: fill this class\
        public double Real {get;}
        public double Imaginary {get;}

        public double Modulus => Math.Sqrt(Math.Pow(Real, 2) + Math.Pow(Imaginary, 2));

        public double Phase =>  Math.Pow(Math.Tan(Imaginary), -1) / Real;

        public Complex Complement => new Complex(Real, -Imaginary);

        public override string ToString()
        {
            return $"Z = {Real} + i{Imaginary}";
        }

        public static Complex operator +(Complex n1, Complex n2) => new Complex(n1.Real + n2.Real, n1.Imaginary + n2.Imaginary);

        public static Complex operator -(Complex n1, Complex n2) => new Complex(n1.Real + n2.Real, n1.Imaginary + n2.Imaginary);

        public Complex (double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }
    }
}