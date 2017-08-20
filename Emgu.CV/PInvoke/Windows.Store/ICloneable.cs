﻿//----------------------------------------------------------------------------
//  Copyright (C) 2004-2017 by EMGU Corporation. All rights reserved.       
//----------------------------------------------------------------------------

#if NETFX_CORE || NET_STANDARD1_4
namespace System
{
   /// <summary>
   /// Replicate of the System.ICloneable interface in .NET that do not exist in NETFX_CORE || NET_STANDARD1_4
   /// </summary>
   public interface ICloneable
   {
      /// <summary>
      /// Return a clone of the object
      /// </summary>
      /// <returns>A clone of the object</returns>
      object Clone();
   }
}
#endif
