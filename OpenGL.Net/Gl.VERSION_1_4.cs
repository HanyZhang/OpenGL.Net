
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
		/// Value of GL_BLEND_DST_RGB symbol.
		/// </summary>
		[AliasOf("GL_BLEND_DST_RGB_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		public const int BLEND_DST_RGB = 0x80C8;

		/// <summary>
		/// Value of GL_BLEND_SRC_RGB symbol.
		/// </summary>
		[AliasOf("GL_BLEND_SRC_RGB_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		public const int BLEND_SRC_RGB = 0x80C9;

		/// <summary>
		/// Value of GL_BLEND_DST_ALPHA symbol.
		/// </summary>
		[AliasOf("GL_BLEND_DST_ALPHA_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		public const int BLEND_DST_ALPHA = 0x80CA;

		/// <summary>
		/// Value of GL_BLEND_SRC_ALPHA symbol.
		/// </summary>
		[AliasOf("GL_BLEND_SRC_ALPHA_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		public const int BLEND_SRC_ALPHA = 0x80CB;

		/// <summary>
		/// Value of GL_POINT_FADE_THRESHOLD_SIZE symbol.
		/// </summary>
		[AliasOf("GL_POINT_FADE_THRESHOLD_SIZE_ARB")]
		[AliasOf("GL_POINT_FADE_THRESHOLD_SIZE_EXT")]
		[AliasOf("GL_POINT_FADE_THRESHOLD_SIZE_SGIS")]
		[RequiredByFeature("GL_VERSION_1_4")]
		public const int POINT_FADE_THRESHOLD_SIZE = 0x8128;

		/// <summary>
		/// Value of GL_DEPTH_COMPONENT16 symbol.
		/// </summary>
		[AliasOf("GL_DEPTH_COMPONENT16_ARB")]
		[AliasOf("GL_DEPTH_COMPONENT16_SGIX")]
		[RequiredByFeature("GL_VERSION_1_4")]
		public const int DEPTH_COMPONENT16 = 0x81A5;

		/// <summary>
		/// Value of GL_DEPTH_COMPONENT24 symbol.
		/// </summary>
		[AliasOf("GL_DEPTH_COMPONENT24_ARB")]
		[AliasOf("GL_DEPTH_COMPONENT24_SGIX")]
		[RequiredByFeature("GL_VERSION_1_4")]
		public const int DEPTH_COMPONENT24 = 0x81A6;

		/// <summary>
		/// Value of GL_DEPTH_COMPONENT32 symbol.
		/// </summary>
		[AliasOf("GL_DEPTH_COMPONENT32_ARB")]
		[AliasOf("GL_DEPTH_COMPONENT32_SGIX")]
		[RequiredByFeature("GL_VERSION_1_4")]
		public const int DEPTH_COMPONENT32 = 0x81A7;

		/// <summary>
		/// Value of GL_MIRRORED_REPEAT symbol.
		/// </summary>
		[AliasOf("GL_MIRRORED_REPEAT_ARB")]
		[AliasOf("GL_MIRRORED_REPEAT_IBM")]
		[RequiredByFeature("GL_VERSION_1_4")]
		public const int MIRRORED_REPEAT = 0x8370;

		/// <summary>
		/// Value of GL_MAX_TEXTURE_LOD_BIAS symbol.
		/// </summary>
		[AliasOf("GL_MAX_TEXTURE_LOD_BIAS_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		public const int MAX_TEXTURE_LOD_BIAS = 0x84FD;

		/// <summary>
		/// Value of GL_TEXTURE_LOD_BIAS symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE_LOD_BIAS_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		public const int TEXTURE_LOD_BIAS = 0x8501;

		/// <summary>
		/// Value of GL_INCR_WRAP symbol.
		/// </summary>
		[AliasOf("GL_INCR_WRAP_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		public const int INCR_WRAP = 0x8507;

		/// <summary>
		/// Value of GL_DECR_WRAP symbol.
		/// </summary>
		[AliasOf("GL_DECR_WRAP_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		public const int DECR_WRAP = 0x8508;

		/// <summary>
		/// Value of GL_TEXTURE_DEPTH_SIZE symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE_DEPTH_SIZE_ARB")]
		[RequiredByFeature("GL_VERSION_1_4")]
		public const int TEXTURE_DEPTH_SIZE = 0x884A;

		/// <summary>
		/// Value of GL_TEXTURE_COMPARE_MODE symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE_COMPARE_MODE_ARB")]
		[RequiredByFeature("GL_VERSION_1_4")]
		public const int TEXTURE_COMPARE_MODE = 0x884C;

		/// <summary>
		/// Value of GL_TEXTURE_COMPARE_FUNC symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE_COMPARE_FUNC_ARB")]
		[RequiredByFeature("GL_VERSION_1_4")]
		public const int TEXTURE_COMPARE_FUNC = 0x884D;

		/// <summary>
		/// Value of GL_POINT_SIZE_MIN symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_POINT_SIZE_MIN_ARB")]
		[AliasOf("GL_POINT_SIZE_MIN_EXT")]
		[AliasOf("GL_POINT_SIZE_MIN_SGIS")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int POINT_SIZE_MIN = 0x8126;

		/// <summary>
		/// Value of GL_POINT_SIZE_MAX symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_POINT_SIZE_MAX_ARB")]
		[AliasOf("GL_POINT_SIZE_MAX_EXT")]
		[AliasOf("GL_POINT_SIZE_MAX_SGIS")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int POINT_SIZE_MAX = 0x8127;

		/// <summary>
		/// Value of GL_POINT_DISTANCE_ATTENUATION symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_POINT_DISTANCE_ATTENUATION_ARB")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int POINT_DISTANCE_ATTENUATION = 0x8129;

		/// <summary>
		/// Value of GL_GENERATE_MIPMAP symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_GENERATE_MIPMAP_SGIS")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int GENERATE_MIPMAP = 0x8191;

		/// <summary>
		/// Value of GL_GENERATE_MIPMAP_HINT symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_GENERATE_MIPMAP_HINT_SGIS")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int GENERATE_MIPMAP_HINT = 0x8192;

		/// <summary>
		/// Value of GL_FOG_COORDINATE_SOURCE symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_FOG_COORDINATE_SOURCE_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FOG_COORDINATE_SOURCE = 0x8450;

		/// <summary>
		/// Value of GL_FOG_COORDINATE symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_FOG_COORDINATE_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FOG_COORDINATE = 0x8451;

		/// <summary>
		/// Value of GL_FRAGMENT_DEPTH symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_FRAGMENT_DEPTH_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FRAGMENT_DEPTH = 0x8452;

		/// <summary>
		/// Value of GL_CURRENT_FOG_COORDINATE symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_CURRENT_FOG_COORDINATE_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CURRENT_FOG_COORDINATE = 0x8453;

		/// <summary>
		/// Value of GL_FOG_COORDINATE_ARRAY_TYPE symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_FOG_COORDINATE_ARRAY_TYPE_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FOG_COORDINATE_ARRAY_TYPE = 0x8454;

		/// <summary>
		/// Value of GL_FOG_COORDINATE_ARRAY_STRIDE symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_FOG_COORDINATE_ARRAY_STRIDE_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FOG_COORDINATE_ARRAY_STRIDE = 0x8455;

		/// <summary>
		/// Value of GL_FOG_COORDINATE_ARRAY_POINTER symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_FOG_COORDINATE_ARRAY_POINTER_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FOG_COORDINATE_ARRAY_POINTER = 0x8456;

		/// <summary>
		/// Value of GL_FOG_COORDINATE_ARRAY symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_FOG_COORDINATE_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FOG_COORDINATE_ARRAY = 0x8457;

		/// <summary>
		/// Value of GL_COLOR_SUM symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_COLOR_SUM_ARB")]
		[AliasOf("GL_COLOR_SUM_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COLOR_SUM = 0x8458;

		/// <summary>
		/// Value of GL_CURRENT_SECONDARY_COLOR symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_CURRENT_SECONDARY_COLOR_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CURRENT_SECONDARY_COLOR = 0x8459;

		/// <summary>
		/// Value of GL_SECONDARY_COLOR_ARRAY_SIZE symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_SECONDARY_COLOR_ARRAY_SIZE_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SECONDARY_COLOR_ARRAY_SIZE = 0x845A;

		/// <summary>
		/// Value of GL_SECONDARY_COLOR_ARRAY_TYPE symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_SECONDARY_COLOR_ARRAY_TYPE_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SECONDARY_COLOR_ARRAY_TYPE = 0x845B;

		/// <summary>
		/// Value of GL_SECONDARY_COLOR_ARRAY_STRIDE symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_SECONDARY_COLOR_ARRAY_STRIDE_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SECONDARY_COLOR_ARRAY_STRIDE = 0x845C;

		/// <summary>
		/// Value of GL_SECONDARY_COLOR_ARRAY_POINTER symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_SECONDARY_COLOR_ARRAY_POINTER_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SECONDARY_COLOR_ARRAY_POINTER = 0x845D;

		/// <summary>
		/// Value of GL_SECONDARY_COLOR_ARRAY symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_SECONDARY_COLOR_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SECONDARY_COLOR_ARRAY = 0x845E;

		/// <summary>
		/// Value of GL_TEXTURE_FILTER_CONTROL symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_TEXTURE_FILTER_CONTROL_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TEXTURE_FILTER_CONTROL = 0x8500;

		/// <summary>
		/// Value of GL_DEPTH_TEXTURE_MODE symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_DEPTH_TEXTURE_MODE_ARB")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int DEPTH_TEXTURE_MODE = 0x884B;

		/// <summary>
		/// Value of GL_COMPARE_R_TO_TEXTURE symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_COMPARE_R_TO_TEXTURE_ARB")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COMPARE_R_TO_TEXTURE = 0x884E;

		/// <summary>
		/// Value of GL_FUNC_ADD symbol.
		/// </summary>
		[AliasOf("GL_FUNC_ADD_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int FUNC_ADD = 0x8006;

		/// <summary>
		/// Value of GL_FUNC_SUBTRACT symbol.
		/// </summary>
		[AliasOf("GL_FUNC_SUBTRACT_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int FUNC_SUBTRACT = 0x800A;

		/// <summary>
		/// Value of GL_FUNC_REVERSE_SUBTRACT symbol.
		/// </summary>
		[AliasOf("GL_FUNC_REVERSE_SUBTRACT_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int FUNC_REVERSE_SUBTRACT = 0x800B;

		/// <summary>
		/// Value of GL_MIN symbol.
		/// </summary>
		[AliasOf("GL_MIN_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int MIN = 0x8007;

		/// <summary>
		/// Value of GL_MAX symbol.
		/// </summary>
		[AliasOf("GL_MAX_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int MAX = 0x8008;

		/// <summary>
		/// Value of GL_CONSTANT_COLOR symbol.
		/// </summary>
		[AliasOf("GL_CONSTANT_COLOR_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int CONSTANT_COLOR = 0x8001;

		/// <summary>
		/// Value of GL_ONE_MINUS_CONSTANT_COLOR symbol.
		/// </summary>
		[AliasOf("GL_ONE_MINUS_CONSTANT_COLOR_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int ONE_MINUS_CONSTANT_COLOR = 0x8002;

		/// <summary>
		/// Value of GL_CONSTANT_ALPHA symbol.
		/// </summary>
		[AliasOf("GL_CONSTANT_ALPHA_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int CONSTANT_ALPHA = 0x8003;

		/// <summary>
		/// Value of GL_ONE_MINUS_CONSTANT_ALPHA symbol.
		/// </summary>
		[AliasOf("GL_ONE_MINUS_CONSTANT_ALPHA_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ARB_imaging")]
		public const int ONE_MINUS_CONSTANT_ALPHA = 0x8004;

		/// <summary>
		/// specify pixel arithmetic for RGB and alpha components separately
		/// </summary>
		/// <param name="sfactorRGB">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="dfactorRGB">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="sfactorAlpha">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="dfactorAlpha">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		public static void BlendFuncSeparate(int sfactorRGB, int dfactorRGB, int sfactorAlpha, int dfactorAlpha)
		{
			Debug.Assert(Delegates.pglBlendFuncSeparate != null, "pglBlendFuncSeparate not implemented");
			Delegates.pglBlendFuncSeparate(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
			CallLog("glBlendFuncSeparate({0}, {1}, {2}, {3})", sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
			DebugCheckErrors();
		}

		/// <summary>
		/// render multiple sets of primitives from array data
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, 
		/// GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
		/// </param>
		/// <param name="first">
		/// Points to an array of starting indices in the enabled arrays.
		/// </param>
		/// <param name="count">
		/// Points to an array of the number of indices to be rendered.
		/// </param>
		/// <param name="drawcount">
		/// Specifies the size of the first and count
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		public static void MultiDrawArrays(PrimitiveType mode, Int32[] first, Int32[] count, Int32 drawcount)
		{
			unsafe {
				fixed (Int32* p_first = first)
				fixed (Int32* p_count = count)
				{
					Debug.Assert(Delegates.pglMultiDrawArrays != null, "pglMultiDrawArrays not implemented");
					Delegates.pglMultiDrawArrays((int)mode, p_first, p_count, drawcount);
					CallLog("glMultiDrawArrays({0}, {1}, {2}, {3})", mode, first, count, drawcount);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// render multiple sets of primitives by specifying indices of array data elements
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, 
		/// GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
		/// </param>
		/// <param name="count">
		/// Points to an array of the elements counts.
		/// </param>
		/// <param name="type">
		/// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
		/// </param>
		/// <param name="indices">
		/// Specifies a pointer to the location where the indices are stored.
		/// </param>
		/// <param name="drawcount">
		/// Specifies the size of the count and indices arrays.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		public static void MultiDrawElements(PrimitiveType mode, Int32[] count, DrawElementsType type, IntPtr[] indices, Int32 drawcount)
		{
			unsafe {
				fixed (Int32* p_count = count)
				fixed (IntPtr* p_indices = indices)
				{
					Debug.Assert(Delegates.pglMultiDrawElements != null, "pglMultiDrawElements not implemented");
					Delegates.pglMultiDrawElements((int)mode, p_count, (int)type, p_indices, drawcount);
					CallLog("glMultiDrawElements({0}, {1}, {2}, {3}, {4})", mode, count, type, indices, drawcount);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// specify point parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued point parameter. GL_POINT_FADE_THRESHOLD_SIZE, and GL_POINT_SPRITE_COORD_ORIGIN are accepted.
		/// </param>
		/// <param name="param">
		/// For glPointParameterf and glPointParameteri, specifies the value that pname will be set to.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		public static void PointParameter(int pname, float param)
		{
			Debug.Assert(Delegates.pglPointParameterf != null, "pglPointParameterf not implemented");
			Delegates.pglPointParameterf(pname, param);
			CallLog("glPointParameterf({0}, {1})", pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify point parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued point parameter. GL_POINT_FADE_THRESHOLD_SIZE, and GL_POINT_SPRITE_COORD_ORIGIN are accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		public static void PointParameter(int pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglPointParameterfv != null, "pglPointParameterfv not implemented");
					Delegates.pglPointParameterfv(pname, p_params);
					CallLog("glPointParameterfv({0}, {1})", pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// specify point parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued point parameter. GL_POINT_FADE_THRESHOLD_SIZE, and GL_POINT_SPRITE_COORD_ORIGIN are accepted.
		/// </param>
		/// <param name="param">
		/// For glPointParameterf and glPointParameteri, specifies the value that pname will be set to.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		public static void PointParameter(int pname, Int32 param)
		{
			Debug.Assert(Delegates.pglPointParameteri != null, "pglPointParameteri not implemented");
			Delegates.pglPointParameteri(pname, param);
			CallLog("glPointParameteri({0}, {1})", pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify point parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued point parameter. GL_POINT_FADE_THRESHOLD_SIZE, and GL_POINT_SPRITE_COORD_ORIGIN are accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		public static void PointParameter(int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglPointParameteriv != null, "pglPointParameteriv not implemented");
					Delegates.pglPointParameteriv(pname, p_params);
					CallLog("glPointParameteriv({0}, {1})", pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current fog coordinates
		/// </summary>
		/// <param name="coord">
		/// Specify the fog distance.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void FogCoord(float coord)
		{
			Debug.Assert(Delegates.pglFogCoordf != null, "pglFogCoordf not implemented");
			Delegates.pglFogCoordf(coord);
			CallLog("glFogCoordf({0})", coord);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current fog coordinates
		/// </summary>
		/// <param name="coord">
		/// Specify the fog distance.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void FogCoord(float[] coord)
		{
			unsafe {
				fixed (float* p_coord = coord)
				{
					Debug.Assert(Delegates.pglFogCoordfv != null, "pglFogCoordfv not implemented");
					Delegates.pglFogCoordfv(p_coord);
					CallLog("glFogCoordfv({0})", coord);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current fog coordinates
		/// </summary>
		/// <param name="coord">
		/// Specify the fog distance.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void FogCoord(double coord)
		{
			Debug.Assert(Delegates.pglFogCoordd != null, "pglFogCoordd not implemented");
			Delegates.pglFogCoordd(coord);
			CallLog("glFogCoordd({0})", coord);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current fog coordinates
		/// </summary>
		/// <param name="coord">
		/// Specify the fog distance.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void FogCoord(double[] coord)
		{
			unsafe {
				fixed (double* p_coord = coord)
				{
					Debug.Assert(Delegates.pglFogCoorddv != null, "pglFogCoorddv not implemented");
					Delegates.pglFogCoorddv(p_coord);
					CallLog("glFogCoorddv({0})", coord);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// define an array of fog coordinates
		/// </summary>
		/// <param name="type">
		/// Specifies the data type of each fog coordinate. Symbolic constants <see cref="Gl.FLOAT"/>, or <see cref="Gl.DOUBLE"/> 
		/// are accepted. The initial value is <see cref="Gl.FLOAT"/>.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive fog coordinates. If <paramref name="stride"/> is 0, the array elements are 
		/// understood to be tightly packed. The initial value is 0.
		/// </param>
		/// <param name="pointer">
		/// Specifies a pointer to the first coordinate of the first fog coordinate in the array. The initial value is 0.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void FogCoordPointer(FogPointerTypeEXT type, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglFogCoordPointer != null, "pglFogCoordPointer not implemented");
			Delegates.pglFogCoordPointer((int)type, stride, pointer);
			CallLog("glFogCoordPointer({0}, {1}, {2})", type, stride, pointer);
			DebugCheckErrors();
		}

		/// <summary>
		/// define an array of fog coordinates
		/// </summary>
		/// <param name="type">
		/// Specifies the data type of each fog coordinate. Symbolic constants <see cref="Gl.FLOAT"/>, or <see cref="Gl.DOUBLE"/> 
		/// are accepted. The initial value is <see cref="Gl.FLOAT"/>.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive fog coordinates. If <paramref name="stride"/> is 0, the array elements are 
		/// understood to be tightly packed. The initial value is 0.
		/// </param>
		/// <param name="pointer">
		/// Specifies a pointer to the first coordinate of the first fog coordinate in the array. The initial value is 0.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void FogCoordPointer(FogPointerTypeEXT type, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				FogCoordPointer(type, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// set the current secondary color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColor3(sbyte red, sbyte green, sbyte blue)
		{
			Debug.Assert(Delegates.pglSecondaryColor3b != null, "pglSecondaryColor3b not implemented");
			Delegates.pglSecondaryColor3b(red, green, blue);
			CallLog("glSecondaryColor3b({0}, {1}, {2})", red, green, blue);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current secondary color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:sbyte[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColor3(sbyte[] v)
		{
			unsafe {
				fixed (sbyte* p_v = v)
				{
					Debug.Assert(Delegates.pglSecondaryColor3bv != null, "pglSecondaryColor3bv not implemented");
					Delegates.pglSecondaryColor3bv(p_v);
					CallLog("glSecondaryColor3bv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current secondary color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColor3(double red, double green, double blue)
		{
			Debug.Assert(Delegates.pglSecondaryColor3d != null, "pglSecondaryColor3d not implemented");
			Delegates.pglSecondaryColor3d(red, green, blue);
			CallLog("glSecondaryColor3d({0}, {1}, {2})", red, green, blue);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current secondary color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColor3(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglSecondaryColor3dv != null, "pglSecondaryColor3dv not implemented");
					Delegates.pglSecondaryColor3dv(p_v);
					CallLog("glSecondaryColor3dv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current secondary color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColor3(float red, float green, float blue)
		{
			Debug.Assert(Delegates.pglSecondaryColor3f != null, "pglSecondaryColor3f not implemented");
			Delegates.pglSecondaryColor3f(red, green, blue);
			CallLog("glSecondaryColor3f({0}, {1}, {2})", red, green, blue);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current secondary color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColor3(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglSecondaryColor3fv != null, "pglSecondaryColor3fv not implemented");
					Delegates.pglSecondaryColor3fv(p_v);
					CallLog("glSecondaryColor3fv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current secondary color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColor3(Int32 red, Int32 green, Int32 blue)
		{
			Debug.Assert(Delegates.pglSecondaryColor3i != null, "pglSecondaryColor3i not implemented");
			Delegates.pglSecondaryColor3i(red, green, blue);
			CallLog("glSecondaryColor3i({0}, {1}, {2})", red, green, blue);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current secondary color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColor3(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglSecondaryColor3iv != null, "pglSecondaryColor3iv not implemented");
					Delegates.pglSecondaryColor3iv(p_v);
					CallLog("glSecondaryColor3iv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current secondary color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColor3(Int16 red, Int16 green, Int16 blue)
		{
			Debug.Assert(Delegates.pglSecondaryColor3s != null, "pglSecondaryColor3s not implemented");
			Delegates.pglSecondaryColor3s(red, green, blue);
			CallLog("glSecondaryColor3s({0}, {1}, {2})", red, green, blue);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current secondary color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColor3(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglSecondaryColor3sv != null, "pglSecondaryColor3sv not implemented");
					Delegates.pglSecondaryColor3sv(p_v);
					CallLog("glSecondaryColor3sv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current secondary color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColor3(byte red, byte green, byte blue)
		{
			Debug.Assert(Delegates.pglSecondaryColor3ub != null, "pglSecondaryColor3ub not implemented");
			Delegates.pglSecondaryColor3ub(red, green, blue);
			CallLog("glSecondaryColor3ub({0}, {1}, {2})", red, green, blue);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current secondary color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColor3(byte[] v)
		{
			unsafe {
				fixed (byte* p_v = v)
				{
					Debug.Assert(Delegates.pglSecondaryColor3ubv != null, "pglSecondaryColor3ubv not implemented");
					Delegates.pglSecondaryColor3ubv(p_v);
					CallLog("glSecondaryColor3ubv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current secondary color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColor3(UInt32 red, UInt32 green, UInt32 blue)
		{
			Debug.Assert(Delegates.pglSecondaryColor3ui != null, "pglSecondaryColor3ui not implemented");
			Delegates.pglSecondaryColor3ui(red, green, blue);
			CallLog("glSecondaryColor3ui({0}, {1}, {2})", red, green, blue);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current secondary color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColor3(UInt32[] v)
		{
			unsafe {
				fixed (UInt32* p_v = v)
				{
					Debug.Assert(Delegates.pglSecondaryColor3uiv != null, "pglSecondaryColor3uiv not implemented");
					Delegates.pglSecondaryColor3uiv(p_v);
					CallLog("glSecondaryColor3uiv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current secondary color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColor3(UInt16 red, UInt16 green, UInt16 blue)
		{
			Debug.Assert(Delegates.pglSecondaryColor3us != null, "pglSecondaryColor3us not implemented");
			Delegates.pglSecondaryColor3us(red, green, blue);
			CallLog("glSecondaryColor3us({0}, {1}, {2})", red, green, blue);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current secondary color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColor3(UInt16[] v)
		{
			unsafe {
				fixed (UInt16* p_v = v)
				{
					Debug.Assert(Delegates.pglSecondaryColor3usv != null, "pglSecondaryColor3usv not implemented");
					Delegates.pglSecondaryColor3usv(p_v);
					CallLog("glSecondaryColor3usv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// define an array of secondary colors
		/// </summary>
		/// <param name="size">
		/// Specifies the number of components per color. Must be 3.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of each color component in the array. Symbolic constants <see cref="Gl.BYTE"/>, <see 
		/// cref="Gl.UNSIGNED_BYTE"/>, <see cref="Gl.SHORT"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.INT"/>, <see 
		/// cref="Gl.UNSIGNED_INT"/>, <see cref="Gl.FLOAT"/>, or <see cref="Gl.DOUBLE"/> are accepted. The initial value is <see 
		/// cref="Gl.FLOAT"/>.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive colors. If <paramref name="stride"/> is 0, the colors are understood to be 
		/// tightly packed in the array. The initial value is 0.
		/// </param>
		/// <param name="pointer">
		/// Specifies a pointer to the first component of the first color element in the array. The initial value is 0.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColorPointer(Int32 size, ColorPointerType type, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglSecondaryColorPointer != null, "pglSecondaryColorPointer not implemented");
			Delegates.pglSecondaryColorPointer(size, (int)type, stride, pointer);
			CallLog("glSecondaryColorPointer({0}, {1}, {2}, {3})", size, type, stride, pointer);
			DebugCheckErrors();
		}

		/// <summary>
		/// define an array of secondary colors
		/// </summary>
		/// <param name="size">
		/// Specifies the number of components per color. Must be 3.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of each color component in the array. Symbolic constants <see cref="Gl.BYTE"/>, <see 
		/// cref="Gl.UNSIGNED_BYTE"/>, <see cref="Gl.SHORT"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.INT"/>, <see 
		/// cref="Gl.UNSIGNED_INT"/>, <see cref="Gl.FLOAT"/>, or <see cref="Gl.DOUBLE"/> are accepted. The initial value is <see 
		/// cref="Gl.FLOAT"/>.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive colors. If <paramref name="stride"/> is 0, the colors are understood to be 
		/// tightly packed in the array. The initial value is 0.
		/// </param>
		/// <param name="pointer">
		/// Specifies a pointer to the first component of the first color element in the array. The initial value is 0.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColorPointer(Int32 size, ColorPointerType type, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				SecondaryColorPointer(size, type, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// specify the raster position in window coordinates for pixel operations
		/// </summary>
		/// <param name="x">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void WindowPos2(double x, double y)
		{
			Debug.Assert(Delegates.pglWindowPos2d != null, "pglWindowPos2d not implemented");
			Delegates.pglWindowPos2d(x, y);
			CallLog("glWindowPos2d({0}, {1})", x, y);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the raster position in window coordinates for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void WindowPos2(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglWindowPos2dv != null, "pglWindowPos2dv not implemented");
					Delegates.pglWindowPos2dv(p_v);
					CallLog("glWindowPos2dv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the raster position in window coordinates for pixel operations
		/// </summary>
		/// <param name="x">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void WindowPos2(float x, float y)
		{
			Debug.Assert(Delegates.pglWindowPos2f != null, "pglWindowPos2f not implemented");
			Delegates.pglWindowPos2f(x, y);
			CallLog("glWindowPos2f({0}, {1})", x, y);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the raster position in window coordinates for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void WindowPos2(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglWindowPos2fv != null, "pglWindowPos2fv not implemented");
					Delegates.pglWindowPos2fv(p_v);
					CallLog("glWindowPos2fv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the raster position in window coordinates for pixel operations
		/// </summary>
		/// <param name="x">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void WindowPos2(Int32 x, Int32 y)
		{
			Debug.Assert(Delegates.pglWindowPos2i != null, "pglWindowPos2i not implemented");
			Delegates.pglWindowPos2i(x, y);
			CallLog("glWindowPos2i({0}, {1})", x, y);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the raster position in window coordinates for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void WindowPos2(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglWindowPos2iv != null, "pglWindowPos2iv not implemented");
					Delegates.pglWindowPos2iv(p_v);
					CallLog("glWindowPos2iv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the raster position in window coordinates for pixel operations
		/// </summary>
		/// <param name="x">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void WindowPos2(Int16 x, Int16 y)
		{
			Debug.Assert(Delegates.pglWindowPos2s != null, "pglWindowPos2s not implemented");
			Delegates.pglWindowPos2s(x, y);
			CallLog("glWindowPos2s({0}, {1})", x, y);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the raster position in window coordinates for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void WindowPos2(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglWindowPos2sv != null, "pglWindowPos2sv not implemented");
					Delegates.pglWindowPos2sv(p_v);
					CallLog("glWindowPos2sv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the raster position in window coordinates for pixel operations
		/// </summary>
		/// <param name="x">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		/// <param name="z">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void WindowPos3(double x, double y, double z)
		{
			Debug.Assert(Delegates.pglWindowPos3d != null, "pglWindowPos3d not implemented");
			Delegates.pglWindowPos3d(x, y, z);
			CallLog("glWindowPos3d({0}, {1}, {2})", x, y, z);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the raster position in window coordinates for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void WindowPos3(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglWindowPos3dv != null, "pglWindowPos3dv not implemented");
					Delegates.pglWindowPos3dv(p_v);
					CallLog("glWindowPos3dv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the raster position in window coordinates for pixel operations
		/// </summary>
		/// <param name="x">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		/// <param name="z">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void WindowPos3(float x, float y, float z)
		{
			Debug.Assert(Delegates.pglWindowPos3f != null, "pglWindowPos3f not implemented");
			Delegates.pglWindowPos3f(x, y, z);
			CallLog("glWindowPos3f({0}, {1}, {2})", x, y, z);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the raster position in window coordinates for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void WindowPos3(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglWindowPos3fv != null, "pglWindowPos3fv not implemented");
					Delegates.pglWindowPos3fv(p_v);
					CallLog("glWindowPos3fv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the raster position in window coordinates for pixel operations
		/// </summary>
		/// <param name="x">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		/// <param name="z">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void WindowPos3(Int32 x, Int32 y, Int32 z)
		{
			Debug.Assert(Delegates.pglWindowPos3i != null, "pglWindowPos3i not implemented");
			Delegates.pglWindowPos3i(x, y, z);
			CallLog("glWindowPos3i({0}, {1}, {2})", x, y, z);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the raster position in window coordinates for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void WindowPos3(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglWindowPos3iv != null, "pglWindowPos3iv not implemented");
					Delegates.pglWindowPos3iv(p_v);
					CallLog("glWindowPos3iv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the raster position in window coordinates for pixel operations
		/// </summary>
		/// <param name="x">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		/// <param name="z">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void WindowPos3(Int16 x, Int16 y, Int16 z)
		{
			Debug.Assert(Delegates.pglWindowPos3s != null, "pglWindowPos3s not implemented");
			Delegates.pglWindowPos3s(x, y, z);
			CallLog("glWindowPos3s({0}, {1}, {2})", x, y, z);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the raster position in window coordinates for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void WindowPos3(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglWindowPos3sv != null, "pglWindowPos3sv not implemented");
					Delegates.pglWindowPos3sv(p_v);
					CallLog("glWindowPos3sv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the blend color
		/// </summary>
		/// <param name="red">
		/// specify the components of GL_BLEND_COLOR
		/// </param>
		/// <param name="green">
		/// specify the components of GL_BLEND_COLOR
		/// </param>
		/// <param name="blue">
		/// specify the components of GL_BLEND_COLOR
		/// </param>
		/// <param name="alpha">
		/// specify the components of GL_BLEND_COLOR
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ARB_imaging")]
		public static void BlendColor(float red, float green, float blue, float alpha)
		{
			Debug.Assert(Delegates.pglBlendColor != null, "pglBlendColor not implemented");
			Delegates.pglBlendColor(red, green, blue, alpha);
			CallLog("glBlendColor({0}, {1}, {2}, {3})", red, green, blue, alpha);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the equation used for both the RGB blend equation and the Alpha blend equation
		/// </summary>
		/// <param name="mode">
		/// specifies how source and destination colors are combined. It must be <see cref="Gl.FUNC_ADD"/>, <see 
		/// cref="Gl.FUNC_SUBTRACT"/>, <see cref="Gl.FUNC_REVERSE_SUBTRACT"/>, <see cref="Gl.MIN"/>, <see cref="Gl.MAX"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ARB_imaging")]
		public static void BlendEquation(int mode)
		{
			Debug.Assert(Delegates.pglBlendEquation != null, "pglBlendEquation not implemented");
			Delegates.pglBlendEquation(mode);
			CallLog("glBlendEquation({0})", mode);
			DebugCheckErrors();
		}

	}

}