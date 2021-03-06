﻿using System;
using System.Runtime.InteropServices;

namespace GLFWnet.Binding {
    /// <summary>
    /// Opaque window object pointer.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct GLFWwindow {
        [FieldOffsetAttribute(0)]
        private IntPtr pointer;

        /// <summary>
        /// NULL GLFWwindow pointer
        /// </summary>
        public readonly static GLFWwindow NULL = new GLFWwindow { pointer = IntPtr.Zero };

        public override string ToString() {
            return pointer.ToString();
        }
    }
}
