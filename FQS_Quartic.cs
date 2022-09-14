using System;
using System.Numerics;

namespace FQS_Quartic
{
    public interface Quartic
    {
        //code translated to c# almost entirely from https://github.com/NKrvavica/fqs/blob/master/fqs.py
        public static Complex[] Quadratic(Complex a0, Complex b0, Complex c0)
        {
            Complex a = b0 / a0;
            Complex b = c0 / a0;

            a0 = -0.5 * a;
            Complex delta = a0 * a0 - b;
            Complex sqrt_delta = Complex.Sqrt(delta);

            Complex r1 = a0 - sqrt_delta;
            Complex r2 = a0 + sqrt_delta;

            return new Complex[] { r1, r2 };
        }

        //this only returns the first solution of the cubic
        public static Complex Cubic(Complex a0, Complex b0, Complex c0, Complex d0)
        {
            Complex a = b0 / a0;
            Complex b = c0 / a0;
            Complex c = d0 / a0;

            Complex third = 0.333333333333333333333333333333333333333333333333333333333333;
            Complex a13 = a * third;
            Complex a2 = a13 * a13;

            Complex f = third * b - a2;
            Complex g = a13 * (2 * a2 - b) + c;
            Complex h = 0.25 * g * g + f * f * f;

            Complex cubic_root(Complex x)
            {
                if (x.Real >= 0)
                {
                    return Math.Cbrt(x.Real);
                }
                else
                {
                    return -Math.Cbrt((-x.Real));
                }
            }

            if (f == 0 && g == 0 && h == 0)
            {
                return -cubic_root(c);
            }

            else if (h.Real <= 0)
            {
                Complex j = Complex.Sqrt(-f);
                Complex k = Complex.Acos(-0.5 * g / (j * j * j));
                Complex m = Complex.Cos(third * k);
                return 2 * j * m - a13;
            }

            else
            {
                Complex sqrt_h = Complex.Sqrt(h);
                Complex S = cubic_root(-0.5 * g + sqrt_h);
                Complex U = cubic_root(-0.5 * g - sqrt_h);
                Complex S_plus_U = S + U;
                return S_plus_U - a13;
            }
        }

        public static Complex[] Quartic(Complex a0, Complex b0, Complex c0, Complex d0, Complex e0)
        {
            Complex a = b0 / a0;
            Complex b = c0 / a0;
            Complex c = d0 / a0;
            Complex d = e0 / a0;

            a0 = 0.25 * a;
            Complex a02 = a0 * a0;

            Complex p = 3 * a02 - 0.5 * b;
            Complex q = a * a02 - b * a0 + 0.5 * c;
            Complex r = 3 * a02 * a02 - b * a02 + c * a0 - d;

            Complex z0 = Cubic(1, p, r, p * r - 0.5 * q * q);

            Complex s = Complex.Sqrt(2 * p + 2 * z0.Real);

            Complex t;

            if (s == 0)
            {
                t = z0 * z0 + r;
            }
            else
            {
                t = -q / s;
            }

            Complex[] r0r1 = Quadratic(1, s, z0 + t);
            Complex[] r2r3 = Quadratic(1, -s, z0 - t);

            return new Complex[] { (r0r1[0] - a0), (r0r1[1] - a0), (r2r3[0] - a0), (r2r3[1] - a0) };
        }
    }
}
