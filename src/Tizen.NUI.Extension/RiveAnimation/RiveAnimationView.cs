/*
* Copyright(c) 2021 Samsung Electronics Co., Ltd.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Tizen.NUI.BaseComponents;

namespace Tizen.NUI.Extension
{
    /// <summary>
    /// RiveAnimationView renders an animated vector image (Rive file).
    /// </summary>
    /// <since_tizen> 9 </since_tizen>
    public class RiveAnimationView : View
    {
        static RiveAnimationView() { }

        /// <summary>
        /// RiveAnimationView constructor.
        /// </summary>
        /// <param name="url">The rive resource URL</param>
        /// <since_tizen> 9 </since_tizen>
        public RiveAnimationView(string url) : this(Interop.RiveAnimationView.New(url), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        internal RiveAnimationView(global::System.IntPtr cPtr, bool shown = true) : base(cPtr, shown)
        {
            if (!shown)
            {
                SetVisible(false);
            }
        }

        /// <summary>
        /// Enables or disables the given animation.
        /// </summary>
        /// <param name="animationName">The animation to enable</param>
        /// <param name="on">The enable state of given animation</param>
        /// <since_tizen> 9 </since_tizen>
        public void EnableAnimation(string animationName, bool on)
        {
            Interop.RiveAnimationView.EnableAnimation(SwigCPtr, animationName, on);
        }

        /// <summary>
        /// Play animation.
        /// </summary>
        /// <since_tizen> 9 </since_tizen>
        public void Play()
        {
            Interop.RiveAnimationView.Play(SwigCPtr);
        }

        /// <summary>
        /// Pause animation.
        /// </summary>
        /// <since_tizen> 9 </since_tizen>
        public void Pause()
        {
            Interop.RiveAnimationView.Pause(SwigCPtr);
        }

        /// <summary>
        /// Stop animation.
        /// </summary>
        /// <since_tizen> 9 </since_tizen>
        public void Stop()
        {
            Interop.RiveAnimationView.Stop(SwigCPtr);
        }

        /// <summary>
        /// Sets the shape fill color of given fill.
        /// </summary>
        /// <param name="shapeFillName">The shape fill name</param>
        /// <param name="color">The rgba color</param>
        /// <since_tizen> 9 </since_tizen>
        public void SetShapeFillColor(string shapeFillName, Color color)
        {
            if (color == null)
                 throw new ArgumentNullException(nameof(color));
            Interop.RiveAnimationView.SetShapeFillColor(SwigCPtr, shapeFillName, color.SwigCPtr);
        }

        /// <summary>
        /// Sets the shape stroke color of given stroke.
        /// </summary>
        /// <param name="shapeStrokeName">The shape stroke name</param>
        /// <param name="color">The rgba color</param>
        /// <since_tizen> 9 </since_tizen>
        public void SetShapeStrokeColor(string shapeStrokeName, Color color)
        {
            if (color == null)
                 throw new ArgumentNullException(nameof(color));
            Interop.RiveAnimationView.SetShapeStrokeColor(SwigCPtr, shapeStrokeName, color.SwigCPtr);
        }

        /// <summary>
        /// Sets the opacity of given node.
        /// </summary>
        /// <param name="nodeName">The node name</param>
        /// <param name="opacity">The opacity of given node</param>
        /// <since_tizen> 9 </since_tizen>
        public void SetNodeOpacity(string nodeName, float opacity)
        {
            Interop.RiveAnimationView.SetNodeOpacity(SwigCPtr, nodeName, opacity);
        }

        /// <summary>
        /// Sets the scale of given node.
        /// </summary>
        /// <param name="nodeName">The node name</param>
        /// <param name="scale">The scale of given node</param>
        /// <since_tizen> 9 </since_tizen>
        public void SetNodeScale(string nodeName, Vector2 scale)
        {
            if (scale == null)
                 throw new ArgumentNullException(nameof(scale));
            Interop.RiveAnimationView.SetNodeScale(SwigCPtr, nodeName, Vector2.getCPtr(scale));
        }

        /// <summary>
        /// Sets the rotation of given node.
        /// </summary>
        /// <param name="nodeName">The node name</param>
        /// <param name="degree">The degree of given node</param>
        /// <since_tizen> 9 </since_tizen>
        public void SetNodeRotation(string nodeName, Degree degree)
        {            
            if (degree == null)
                 throw new ArgumentNullException(nameof(degree));
            Interop.RiveAnimationView.SetNodeRotation(SwigCPtr, nodeName, Degree.getCPtr(degree));
        }

        /// <summary>
        /// Sets the position of given node.
        /// </summary>
        /// <param name="nodeName">The node name</param>
        /// <param name="position">The position of given node</param>
        /// <since_tizen> 9 </since_tizen>
        public void SetNodePosition(string nodeName, Position position)
        {
            if (position == null)
                 throw new ArgumentNullException(nameof(position));
            Interop.RiveAnimationView.SetNodePosition(SwigCPtr, nodeName, position.SwigCPtr);
        }

        /// <summary>
        /// Informs the current state machine that a pointing device coordinates are changed.
        /// </summary>
        /// <param name="x">The x position of the mouse or the touch pointer</param>
        /// <param name="y">The y position of the mouse or the touch pointer</param>
        /// <since_tizen> 10 </since_tizen>
        public void PointerMove(float x, float y)
        {
            Interop.RiveAnimationView.PointerMove(SwigCPtr, x, y);
        }

        /// <summary>
        /// Informs the current state machine that a pointing device button is pressed.
        /// </summary>
        /// <param name="x">The x position of the mouse or the touch pointer</param>
        /// <param name="y">The y position of the mouse or the touch pointer</param>
        /// <since_tizen> 10 </since_tizen>
        public void PointerDown(float x, float y)
        {
            Interop.RiveAnimationView.PointerDown(SwigCPtr, x, y);
        }

        /// <summary>
        /// Informs the current state machine that a pointing device button is released.
        /// </summary>
        /// <param name="x">The x position of the mouse or the touch pointer</param>
        /// <param name="y">The y position of the mouse or the touch pointer</param>
        /// <since_tizen> 10 </since_tizen>
        public void PointerUp(float x, float y)
        {
            Interop.RiveAnimationView.PointerUp(SwigCPtr, x, y);
        }

        /// <summary>
        /// Sets the input state on a number input.
        /// </summary>
        /// <param name="stateMachineName">The state machine name. Empty string for a default state machine</param>
        /// <param name="inputName">The input name</param>
        /// <param name="value">The number value</param>
        /// <return> Returns true is success, false otherwise.</return>
        /// <since_tizen> 10 </since_tizen>
        public bool SetNumberState(string stateMachineName, string inputName, float value)
        {
            return Interop.RiveAnimationView.SetNumberState(SwigCPtr, stateMachineName, inputName, value);
        }

        /// <summary>
        /// Sets the input state on a boolean input.
        /// </summary>
        /// <param name="stateMachineName">The state machine name. Empty string for a default state machine</param>
        /// <param name="inputName">The input name</param>
        /// <param name="value">The boolean value</param>
        /// <return> Returns true is success, false otherwise.</return>
        /// <since_tizen> 10 </since_tizen>
        public bool SetBooleanState(string stateMachineName, string inputName, bool value)
        {
            return Interop.RiveAnimationView.SetBooleanState(SwigCPtr, stateMachineName, inputName, value);
        }

        /// <summary>
        /// Fires a trigger input.
        /// </summary>
        /// <param name="stateMachineName">The state machine name. Empty string for a default state machine</param>
        /// <param name="inputName">The input name</param>
        /// <return> Returns true is success, false otherwise.</return>
        /// <since_tizen> 10 </since_tizen>
        public bool FireState(string stateMachineName, string inputName)
        {
            return Interop.RiveAnimationView.FireState(SwigCPtr, stateMachineName, inputName);
        }

        /// <summary>
        /// Sets the animation elapsed time.
        /// </summary>
        /// <param name="animationName">The animation name</param>
        /// <param name="elapsed">The elapsed time in seconds</param>
        /// <since_tizen> 9 </since_tizen>
        public void SetAnimationElapsedTime(string animationName, float elapsed)
        {
            Interop.RiveAnimationView.SetAnimationElapsedTime(SwigCPtr, animationName, elapsed);
        }
    }
}
