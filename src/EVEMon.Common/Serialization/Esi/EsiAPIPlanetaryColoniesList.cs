﻿using EVEMon.Common.Serialization.Eve;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace EVEMon.Common.Serialization.Esi
{
    [CollectionDataContract]
    public sealed class EsiAPIPlanetaryColoniesList : List<EsiPlanetaryColonyListItem>
    {
    }
}
