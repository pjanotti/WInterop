﻿// ------------------------
//    WInterop Framework
// ------------------------

// Copyright (c) Jeremy W. Kuhne. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using FluentAssertions;
using System.Runtime.InteropServices;
using WInterop.Gdi.Types;
using Xunit;

namespace DesktopTests.Gdi
{
    public class DISPLAY_DEVICE_Tests
    {
        [Fact]
        public void MarshalSize()
        {
            Marshal.SizeOf<DISPLAY_DEVICE>().Should().Be(840);
        }
    }
}
