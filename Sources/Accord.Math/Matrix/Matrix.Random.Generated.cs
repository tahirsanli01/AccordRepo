﻿// Accord Math Library
// The Accord.NET Framework
// http://accord-framework.net
//
// Copyright © César Souza, 2009-2017
// cesarsouza at gmail.com
//
//    This library is free software; you can redistribute it and/or
//    modify it under the terms of the GNU Lesser General Public
//    License as published by the Free Software Foundation; either
//    version 2.1 of the License, or (at your option) any later version.
//
//    This library is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
//    Lesser General Public License for more details.
//
//    You should have received a copy of the GNU Lesser General Public
//    License along with this library; if not, write to the Free Software
//    Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
//

// ======================================================================
// This code has been generated by a tool; do not edit manually. Instead,
// edit the T4 template Vector.Random.tt so this file can be regenerated. 
// ======================================================================


namespace Accord.Math
{
    using System;
    using Accord.Math;

    public static partial class Matrix
    {
        /// <summary>
        ///   Creates a matrix with uniformly distributed random data.
        /// </summary>
        /// 
        public static double[,] Random(int rows, int columns)
        {
            return Random(rows, columns, 0.0, 1.0);
        }

        /// <summary>
        ///   Creates a matrix with uniformly distributed random data.
        /// </summary>
        /// 
        public static double[,] Random(int size)
        {
            return Random(size, size, 0.0, 1.0);
        }

        /// <summary>
        ///   Creates a matrix with uniformly distributed random data.
        /// </summary>
        /// 
        public static int[,] Random(int rows, int columns, int min, int max, int[,] result = null)
        {
            if (result == null)
                result = new int[rows, columns];

            var random = Accord.Math.Random.Generator.Random;

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    result[i, j] = (int)random.Next((int)min, (int)max);
            return result;
        }

        /// <summary>
        ///   Creates a matrix with uniformly distributed random data.
        /// </summary>
        /// 
        public static int[,] Random(int size, int min, int max, bool symmetric = false, int[,] result = null)
        {
            if (result == null)
                result = new int[size, size];

            var random = Accord.Math.Random.Generator.Random;

            if (symmetric)
            {
                for (int i = 0; i < size; i++)
                    for (int j = i; j < size; j++)
                        result[i, j] = result[j, i] = (int)random.Next((int)min, (int)max);
            }
            else
            {
                for (int i = 0; i < size; i++)
                    for (int j = i; j < size; j++)
                        result[i, j] = (int)random.Next((int)min, (int)max);
            }
            return result;
        }
        /// <summary>
        ///   Creates a matrix with uniformly distributed random data.
        /// </summary>
        /// 
        public static short[,] Random(int rows, int columns, short min, short max, short[,] result = null)
        {
            if (result == null)
                result = new short[rows, columns];

            var random = Accord.Math.Random.Generator.Random;

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    result[i, j] = (short)random.Next((int)min, (int)max);
            return result;
        }

        /// <summary>
        ///   Creates a matrix with uniformly distributed random data.
        /// </summary>
        /// 
        public static short[,] Random(int size, short min, short max, bool symmetric = false, short[,] result = null)
        {
            if (result == null)
                result = new short[size, size];

            var random = Accord.Math.Random.Generator.Random;

            if (symmetric)
            {
                for (int i = 0; i < size; i++)
                    for (int j = i; j < size; j++)
                        result[i, j] = result[j, i] = (short)random.Next((int)min, (int)max);
            }
            else
            {
                for (int i = 0; i < size; i++)
                    for (int j = i; j < size; j++)
                        result[i, j] = (short)random.Next((int)min, (int)max);
            }
            return result;
        }
        /// <summary>
        ///   Creates a matrix with uniformly distributed random data.
        /// </summary>
        /// 
        public static byte[,] Random(int rows, int columns, byte min, byte max, byte[,] result = null)
        {
            if (result == null)
                result = new byte[rows, columns];

            var random = Accord.Math.Random.Generator.Random;

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    result[i, j] = (byte)random.Next((int)min, (int)max);
            return result;
        }

        /// <summary>
        ///   Creates a matrix with uniformly distributed random data.
        /// </summary>
        /// 
        public static byte[,] Random(int size, byte min, byte max, bool symmetric = false, byte[,] result = null)
        {
            if (result == null)
                result = new byte[size, size];

            var random = Accord.Math.Random.Generator.Random;

            if (symmetric)
            {
                for (int i = 0; i < size; i++)
                    for (int j = i; j < size; j++)
                        result[i, j] = result[j, i] = (byte)random.Next((int)min, (int)max);
            }
            else
            {
                for (int i = 0; i < size; i++)
                    for (int j = i; j < size; j++)
                        result[i, j] = (byte)random.Next((int)min, (int)max);
            }
            return result;
        }
        /// <summary>
        ///   Creates a matrix with uniformly distributed random data.
        /// </summary>
        /// 
        public static sbyte[,] Random(int rows, int columns, sbyte min, sbyte max, sbyte[,] result = null)
        {
            if (result == null)
                result = new sbyte[rows, columns];

            var random = Accord.Math.Random.Generator.Random;

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    result[i, j] = (sbyte)random.Next((int)min, (int)max);
            return result;
        }

        /// <summary>
        ///   Creates a matrix with uniformly distributed random data.
        /// </summary>
        /// 
        public static sbyte[,] Random(int size, sbyte min, sbyte max, bool symmetric = false, sbyte[,] result = null)
        {
            if (result == null)
                result = new sbyte[size, size];

            var random = Accord.Math.Random.Generator.Random;

            if (symmetric)
            {
                for (int i = 0; i < size; i++)
                    for (int j = i; j < size; j++)
                        result[i, j] = result[j, i] = (sbyte)random.Next((int)min, (int)max);
            }
            else
            {
                for (int i = 0; i < size; i++)
                    for (int j = i; j < size; j++)
                        result[i, j] = (sbyte)random.Next((int)min, (int)max);
            }
            return result;
        }
        /// <summary>
        ///   Creates a matrix with uniformly distributed random data.
        /// </summary>
        /// 
        public static long[,] Random(int rows, int columns, long min, long max, long[,] result = null)
        {
            if (result == null)
                result = new long[rows, columns];

            var random = Accord.Math.Random.Generator.Random;

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    result[i, j] = (long)random.Next((int)min, (int)max);
            return result;
        }

        /// <summary>
        ///   Creates a matrix with uniformly distributed random data.
        /// </summary>
        /// 
        public static long[,] Random(int size, long min, long max, bool symmetric = false, long[,] result = null)
        {
            if (result == null)
                result = new long[size, size];

            var random = Accord.Math.Random.Generator.Random;

            if (symmetric)
            {
                for (int i = 0; i < size; i++)
                    for (int j = i; j < size; j++)
                        result[i, j] = result[j, i] = (long)random.Next((int)min, (int)max);
            }
            else
            {
                for (int i = 0; i < size; i++)
                    for (int j = i; j < size; j++)
                        result[i, j] = (long)random.Next((int)min, (int)max);
            }
            return result;
        }
        /// <summary>
        ///   Creates a matrix with uniformly distributed random data.
        /// </summary>
        /// 
        public static ulong[,] Random(int rows, int columns, ulong min, ulong max, ulong[,] result = null)
        {
            if (result == null)
                result = new ulong[rows, columns];

            var random = Accord.Math.Random.Generator.Random;

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    result[i, j] = (ulong)random.Next((int)min, (int)max);
            return result;
        }

        /// <summary>
        ///   Creates a matrix with uniformly distributed random data.
        /// </summary>
        /// 
        public static ulong[,] Random(int size, ulong min, ulong max, bool symmetric = false, ulong[,] result = null)
        {
            if (result == null)
                result = new ulong[size, size];

            var random = Accord.Math.Random.Generator.Random;

            if (symmetric)
            {
                for (int i = 0; i < size; i++)
                    for (int j = i; j < size; j++)
                        result[i, j] = result[j, i] = (ulong)random.Next((int)min, (int)max);
            }
            else
            {
                for (int i = 0; i < size; i++)
                    for (int j = i; j < size; j++)
                        result[i, j] = (ulong)random.Next((int)min, (int)max);
            }
            return result;
        }
        /// <summary>
        ///   Creates a matrix with uniformly distributed random data.
        /// </summary>
        /// 
        public static ushort[,] Random(int rows, int columns, ushort min, ushort max, ushort[,] result = null)
        {
            if (result == null)
                result = new ushort[rows, columns];

            var random = Accord.Math.Random.Generator.Random;

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    result[i, j] = (ushort)random.Next((int)min, (int)max);
            return result;
        }

        /// <summary>
        ///   Creates a matrix with uniformly distributed random data.
        /// </summary>
        /// 
        public static ushort[,] Random(int size, ushort min, ushort max, bool symmetric = false, ushort[,] result = null)
        {
            if (result == null)
                result = new ushort[size, size];

            var random = Accord.Math.Random.Generator.Random;

            if (symmetric)
            {
                for (int i = 0; i < size; i++)
                    for (int j = i; j < size; j++)
                        result[i, j] = result[j, i] = (ushort)random.Next((int)min, (int)max);
            }
            else
            {
                for (int i = 0; i < size; i++)
                    for (int j = i; j < size; j++)
                        result[i, j] = (ushort)random.Next((int)min, (int)max);
            }
            return result;
        }
        /// <summary>
        ///   Creates a matrix with uniformly distributed random data.
        /// </summary>
        /// 
        public static float[,] Random(int rows, int columns, float min, float max, float[,] result = null)
        {
            if (result == null)
                result = new float[rows, columns];

            var random = Accord.Math.Random.Generator.Random;

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    result[i, j] = (float)random.NextDouble() * (max - min) + min;
            return result;
        }

        /// <summary>
        ///   Creates a matrix with uniformly distributed random data.
        /// </summary>
        /// 
        public static float[,] Random(int size, float min, float max, bool symmetric = false, float[,] result = null)
        {
            if (result == null)
                result = new float[size, size];

            var random = Accord.Math.Random.Generator.Random;

            if (symmetric)
            {
                for (int i = 0; i < size; i++)
                    for (int j = i; j < size; j++)
                        result[i, j] = result[j, i] = (float)random.NextDouble() * (max - min) + min;
            }
            else
            {
                for (int i = 0; i < size; i++)
                    for (int j = i; j < size; j++)
                        result[i, j] = (float)random.NextDouble() * (max - min) + min;
            }
            return result;
        }

        /// <summary>
        ///   Creates a matrix with uniformly distributed random data.
        /// </summary>
        /// 
        public static double[,] Random(int rows, int columns, double min, double max, double[,] result = null)
        {
            if (result == null)
                result = new double[rows, columns];

            var random = Accord.Math.Random.Generator.Random;

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    result[i, j] = (double)random.NextDouble() * (max - min) + min;
            return result;
        }

        /// <summary>
        ///   Creates a matrix with uniformly distributed random data.
        /// </summary>
        /// 
        public static double[,] Random(int size, double min, double max, bool symmetric = false, double[,] result = null)
        {
            if (result == null)
                result = new double[size, size];

            var random = Accord.Math.Random.Generator.Random;

            if (symmetric)
            {
                for (int i = 0; i < size; i++)
                    for (int j = i; j < size; j++)
                        result[i, j] = result[j, i] = (double)random.NextDouble() * (max - min) + min;
            }
            else
            {
                for (int i = 0; i < size; i++)
                    for (int j = i; j < size; j++)
                        result[i, j] = (double)random.NextDouble() * (max - min) + min;
            }
            return result;
        }

        /// <summary>
        ///   Creates a matrix with uniformly distributed random data.
        /// </summary>
        /// 
        public static decimal[,] Random(int rows, int columns, decimal min, decimal max, decimal[,] result = null)
        {
            if (result == null)
                result = new decimal[rows, columns];

            var random = Accord.Math.Random.Generator.Random;

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    result[i, j] = (decimal)random.NextDouble() * (max - min) + min;
            return result;
        }

        /// <summary>
        ///   Creates a matrix with uniformly distributed random data.
        /// </summary>
        /// 
        public static decimal[,] Random(int size, decimal min, decimal max, bool symmetric = false, decimal[,] result = null)
        {
            if (result == null)
                result = new decimal[size, size];

            var random = Accord.Math.Random.Generator.Random;

            if (symmetric)
            {
                for (int i = 0; i < size; i++)
                    for (int j = i; j < size; j++)
                        result[i, j] = result[j, i] = (decimal)random.NextDouble() * (max - min) + min;
            }
            else
            {
                for (int i = 0; i < size; i++)
                    for (int j = i; j < size; j++)
                        result[i, j] = (decimal)random.NextDouble() * (max - min) + min;
            }
            return result;
        }

    }
}