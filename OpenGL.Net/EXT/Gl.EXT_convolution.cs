
// Copyright (C) 2015 Luca Piccioni
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
// USA

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// Binding for glGetConvolutionFilterEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ConvolutionTargetEXT"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_convolution")]
		public static void GetConvolutionFilterEXT(ConvolutionTargetEXT target, PixelFormat format, PixelType type, IntPtr image)
		{
			Debug.Assert(Delegates.pglGetConvolutionFilterEXT != null, "pglGetConvolutionFilterEXT not implemented");
			Delegates.pglGetConvolutionFilterEXT((int)target, (int)format, (int)type, image);
			CallLog("glGetConvolutionFilterEXT({0}, {1}, {2}, {3})", target, format, type, image);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetConvolutionFilterEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ConvolutionTargetEXT"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_convolution")]
		public static void GetConvolutionFilterEXT(ConvolutionTargetEXT target, PixelFormat format, PixelType type, Object image)
		{
			GCHandle pin_image = GCHandle.Alloc(image, GCHandleType.Pinned);
			try {
				GetConvolutionFilterEXT(target, format, type, pin_image.AddrOfPinnedObject());
			} finally {
				pin_image.Free();
			}
		}

		/// <summary>
		/// Binding for glGetConvolutionParameterfvEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ConvolutionTargetEXT"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:ConvolutionParameterEXT"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_convolution")]
		public static void GetConvolutionParameterEXT(ConvolutionTargetEXT target, ConvolutionParameterEXT pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetConvolutionParameterfvEXT != null, "pglGetConvolutionParameterfvEXT not implemented");
					Delegates.pglGetConvolutionParameterfvEXT((int)target, (int)pname, p_params);
					CallLog("glGetConvolutionParameterfvEXT({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetConvolutionParameterivEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ConvolutionTargetEXT"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:ConvolutionParameterEXT"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_convolution")]
		public static void GetConvolutionParameterEXT(ConvolutionTargetEXT target, ConvolutionParameterEXT pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetConvolutionParameterivEXT != null, "pglGetConvolutionParameterivEXT not implemented");
					Delegates.pglGetConvolutionParameterivEXT((int)target, (int)pname, p_params);
					CallLog("glGetConvolutionParameterivEXT({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetSeparableFilterEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:SeparableTargetEXT"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="row">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="column">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="span">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_convolution")]
		public static void GetSeparableFilterEXT(SeparableTargetEXT target, PixelFormat format, PixelType type, IntPtr row, IntPtr column, IntPtr span)
		{
			Debug.Assert(Delegates.pglGetSeparableFilterEXT != null, "pglGetSeparableFilterEXT not implemented");
			Delegates.pglGetSeparableFilterEXT((int)target, (int)format, (int)type, row, column, span);
			CallLog("glGetSeparableFilterEXT({0}, {1}, {2}, {3}, {4}, {5})", target, format, type, row, column, span);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetSeparableFilterEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:SeparableTargetEXT"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="row">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <param name="column">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <param name="span">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_convolution")]
		public static void GetSeparableFilterEXT(SeparableTargetEXT target, PixelFormat format, PixelType type, Object row, Object column, Object span)
		{
			GCHandle pin_row = GCHandle.Alloc(row, GCHandleType.Pinned);
			GCHandle pin_column = GCHandle.Alloc(column, GCHandleType.Pinned);
			GCHandle pin_span = GCHandle.Alloc(span, GCHandleType.Pinned);
			try {
				GetSeparableFilterEXT(target, format, type, pin_row.AddrOfPinnedObject(), pin_column.AddrOfPinnedObject(), pin_span.AddrOfPinnedObject());
			} finally {
				pin_row.Free();
				pin_column.Free();
				pin_span.Free();
			}
		}

	}

}