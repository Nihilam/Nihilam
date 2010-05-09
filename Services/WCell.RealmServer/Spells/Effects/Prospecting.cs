/*************************************************************************
 *
 *   file		: Prospecting.cs
 *   copyright		: (C) The WCell Team
 *   email		: info@wcell.org
 *   last changed	: $LastChangedDate: 2009-03-07 07:58:12 +0100 (lø, 07 mar 2009) $
 *   last author	: $LastChangedBy: ralekdev $
 *   revision		: $Rev: 784 $
 *
 *   This program is free software; you can redistribute it and/or modify
 *   it under the terms of the GNU General Public License as published by
 *   the Free Software Foundation; either version 2 of the License, or
 *   (at your option) any later version.
 *
 *************************************************************************/

using WCell.Constants.Items;
using WCell.Constants.Looting;
using WCell.Constants.Spells;

namespace WCell.RealmServer.Spells.Effects
{
	public class ProspectingEffectHandler : ItemConvertEffectHandler
	{
		public ProspectingEffectHandler(SpellCast cast, SpellEffect effect)
			: base(cast, effect)
		{
		}

		public override void Initialize(ref SpellFailedReason failReason)
		{
			if ((m_cast.UsedItem.Template.Flags & ItemFlags.Prospectable) == 0)
			{
				failReason = SpellFailedReason.CantBeProspected;
			}
			else
			{
				base.Initialize(ref failReason);
			}
		}

		public override LootEntryType LootEntryType
		{
			get { return LootEntryType.Prospecting; }
		}
	}
}