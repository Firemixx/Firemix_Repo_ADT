<<<<<<< HEAD
﻿using Content.Shared.Whitelist; // ADT tweak
using Robust.Shared.Containers;
=======
﻿using Content.Shared.Hands.Components;
>>>>>>> upstreamcorv
using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;
using Robust.Shared.Serialization;

namespace Content.Shared.Silicons.Borgs.Components;

/// <summary>
/// This is used for a <see cref="BorgModuleComponent"/> that provides items to the entity it's installed into.
/// </summary>
[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
[Access(typeof(SharedBorgSystem))]
public sealed partial class ItemBorgModuleComponent : Component
{
    /// <summary>
    /// The hands that are provided.
    /// </summary>
    [DataField(required: true)]
    public List<BorgHand> Hands = new();

    /// <summary>
<<<<<<< HEAD
    /// ADT: The droppable items that are provided.
    /// </summary>
    [DataField]
    public List<DroppableBorgItem> DroppableItems = new();

    /// <summary>
    /// The entities from <see cref="Items"/> that were spawned.
=======
    /// The items stored within the hands.
>>>>>>> upstreamcorv
    /// </summary>
    [DataField, AutoNetworkedField]
    public Dictionary<string, EntityUid> StoredItems = new();

    /// <summary>
<<<<<<< HEAD
    /// ADT: The entities from <see cref="Items"/> that were spawned.
    /// </summary>
    [DataField("droppableProvidedItems")]
    public SortedDictionary<string, (EntityUid, DroppableBorgItem)> DroppableProvidedItems = new();

    /// <summary>
    /// A counter that ensures a unique
=======
    /// Whether the provided items have been spawned.
    /// This happens the first time the module is used.
>>>>>>> upstreamcorv
    /// </summary>
    [DataField, AutoNetworkedField]
    public bool Spawned;

    /// <summary>
    /// An ID for the container where items are stored when not in use.
    /// </summary>
    [DataField]
    public string HoldingContainer = "holding_container";
}

<<<<<<< HEAD
// ADT: droppable borg item data definitions
[DataDefinition]
public sealed partial class DroppableBorgItem
{
    [IdDataField]
    public EntProtoId ID;

    [DataField]
    public EntityWhitelist Whitelist;
=======
/// <summary>
/// A single hand provided by the module.
/// </summary>
[DataDefinition, Serializable, NetSerializable]
public partial record struct BorgHand
{
    /// <summary>
    /// The item to spawn in the hand, if any.
    /// </summary>
    [DataField]
    public EntProtoId? Item;

    /// <summary>
    /// The settings for the hand, including a whitelist.
    /// </summary>
    [DataField]
    public Hand Hand = new();

    [DataField]
    public bool ForceRemovable = false;

    public BorgHand(EntProtoId? item, Hand hand, bool forceRemovable = false)
    {
        Item = item;
        Hand = hand;
        ForceRemovable = forceRemovable;
    }
>>>>>>> upstreamcorv
}
