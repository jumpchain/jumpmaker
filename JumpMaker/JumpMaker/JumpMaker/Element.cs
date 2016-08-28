using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpMaker
{
    /// <summary>
    /// Individual element of a jump, has different properties depending on what type of element it is.
    /// </summary>
    class Element : Displayable
    {
        #region properties
        public ElementType Type { get; set; }
        public Dictionary<Property, List<string>> Properties { get; set; }
        #endregion

        #region constructors
        /// <summary>
        /// Construct a new element with a ElementType and certain Name property.
        /// </summary>
        /// <param name="type">What type of ElementType this is e.g. Purchasable.</param>
        /// <param name="name">Name of the element, may or may not be visible on the jump itself.</param>
        public Element(ElementType type, string name)
        {
            Type = type;

            Dictionary<Property, List<string>> properties = new Dictionary<Property, List<string>>();
            properties.Add(Property.Name, new List<string> { name });

            Properties = properties;
        }

        /// <summary>
        /// Construct a new element with a ElementType and the given properties.
        /// </summary>
        /// <param name="type">What type of ElementType this is e.g. Purchasable.</param>
        /// <param name="properties">Properties of the element, can be extensive depending on what is needed.</param>
        public Element(ElementType type, Dictionary<Property, List<string>> properties)
        {

        }
        #endregion

        #region constants
        public enum ElementType
        {
            Purchasable,
            Rollable,
            Choosable,
            Information
        };
        public enum Property
        {
            Name,
            Description,
            Prerequisites,
            Currency,
            Roll,
            Freebies,
            Discounts,
            DiscountStackingBehavior,
            Synergies,
            Rewards
        };
        #endregion
    }
}
