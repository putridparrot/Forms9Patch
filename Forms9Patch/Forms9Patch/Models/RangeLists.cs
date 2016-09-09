﻿using System.Collections.Generic;

#if __IOS__
namespace Forms9Patch.iOS
#elif __DROID__
namespace Forms9Patch.Droid
#else
namespace Forms9Patch
#endif
{
	internal class RangeLists
	{
		public List<Range> PatchesX;
		public List<Range> PatchesY;
		public Range MarginX;
		public Range MarginY;
	}
}
