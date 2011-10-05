﻿﻿/*
 * Copyright (C) 2011 mooege project
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
 */

using Mooege.Core.GS.Game;

namespace Mooege.Core.GS.Objects
{
    public interface IDynamicObject
    {
        /// <summary>
        /// The game the object belongs to.
        /// </summary>
        Mooege.Core.GS.Game.Game Game { get; }

        /// <summary>
        /// The dynamic unique runtime ID for the actor.
        /// </summary>
        uint DynamicID { get; }
    }
}
