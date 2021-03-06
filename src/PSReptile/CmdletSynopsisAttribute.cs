using System;

namespace PSReptile
{
    /// <summary>
    ///     Provides an inline synopsis in the help content for a Cmdlet.
    /// </summary>
    /// <seealso href="https://msdn.microsoft.com/en-us/library/bb525429.aspx"/>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class CmdletSynopsisAttribute
        : Attribute
    {
        /// <summary>
        ///     Provide an inline synopsis for the Cmdlet.
        /// </summary>
        /// <param name="synopsis">
        ///     A brief description of the Cmdlet.
        /// </param>
        public CmdletSynopsisAttribute(string synopsis)
        {
            if (synopsis == null)
                throw new ArgumentNullException(nameof(synopsis));

            Synopsis = synopsis;
        }

        /// <summary>
        ///     A brief description of the Cmdlet.
        /// </summary>
        public string Synopsis { get; }
    }
}
