﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MS-PL license.
// See the LICENSE file in the project root for more information.

using System;
using AndroidX.AppCompat.Widget;
using MvvmCross.Binding;
using MvvmCross.Binding.Bindings.Target;

namespace MvvmCross.DroidX.AppCompat.Target
{
    public class MvxToolbarSubtitleBinding
        : MvxConvertingTargetBinding
    {
        public MvxToolbarSubtitleBinding(Toolbar toolbar)
            : base(toolbar)
        {
        }

        public override Type TargetType => typeof(string);
        public override MvxBindingMode DefaultMode => MvxBindingMode.OneWay;

        protected override void SetValueImpl(object target, object value)
        {
            ((Toolbar)target).Subtitle = (string)value;
        }

        protected Toolbar Toolbar => (Toolbar)Target;
    }
}