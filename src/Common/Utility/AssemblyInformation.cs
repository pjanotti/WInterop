﻿// ------------------------
//    WInterop Framework
// ------------------------

// Copyright (c) Jeremy W. Kuhne. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Reflection;
using System.Resources;
using WInterop;
using WInterop.Utility;

#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif
[assembly: AssemblyCompany("Jeremy W. Kuhne")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: NeutralResourcesLanguage("en")]
[assembly: AssemblyCopyright("Copyright ©" + AutoGeneratedConstants.Strings.CurrentYear)]
[assembly: AssemblyVersion(AssemblyInformation.AssemblyVersionString)]
[assembly: AssemblyFileVersion(AssemblyInformation.AssemblyFileVersionString)]
[assembly: AssemblyInformationalVersion(AssemblyInformation.AssemblyInformationalVersionString)]

namespace WInterop.Utility
{
    internal static class AssemblyInformation
    {
        // Versions are Major.Minor.Build.Revision
        // Max version component value is 65534 (UInt16.MaxValue - 1)
        //
        // A usable scheme for Build is
        //  YMMDD
        //  (Y)ear of development for major/minor: 1 is first year
        //  (MM)onth of build
        //  (DD)ay of build
        //
        // A usable scheme for Revision is
        //  BHHMM
        //  (B)ranch id, or 1
        //  (HH)our of the day
        //  (MM)inute of the day
        //
        // Assembly versions shouldn't get a Build/Revision (*file* versions should) to
        // allow client assemblies to bind against updated builds. Change the version when
        // you make breaking changes to public interfaces.

        public const int MajorVersion = 0;
        public const int MinorVersion = 1;

        public const string MajorMinorVersionString = "0.1";
        public const string PatchLevelString = "1";
        public const string BranchIdString = "1";

        public const string AssemblyVersionString = MajorMinorVersionString + ".0.0";
        public const string AssemblyFileVersionString = MajorMinorVersionString
            + "." + PatchLevelString + AutoGeneratedConstants.Strings.CurrentTwoDigitMonth + AutoGeneratedConstants.Strings.CurrentTwoDigitDayOfMonth
            + "." + BranchIdString + AutoGeneratedConstants.Strings.CurrentTwoDigitHour + AutoGeneratedConstants.Strings.CurrentTwoDigitMinute;

        public const string AssemblyInformationalVersionString = MajorMinorVersionString
            + "." + PatchLevelString + "-alpha-" +AutoGeneratedConstants.Strings.CurrentTwoDigitMonth + AutoGeneratedConstants.Strings.CurrentTwoDigitDayOfMonth
            + BranchIdString + AutoGeneratedConstants.Strings.CurrentTwoDigitHour + AutoGeneratedConstants.Strings.CurrentTwoDigitMinute ;
    }
}
