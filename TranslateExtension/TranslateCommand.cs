using Microsoft;
using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.Commands;
using Microsoft.VisualStudio.Extensibility.Editor;
using Microsoft.VisualStudio.Extensibility.Shell;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace TranslateExtension
{
    /// <summary>
    /// TranslateCommand handler.
    /// </summary>
    [VisualStudioContribution]
    internal class TranslateCommand : Command
    {
        private const string DisplayNameCustom = "Translate To English";
        private readonly TraceSource logger;
        /// <summary>
        /// Initializes a new instance of the <see cref="TranslateCommand"/> class.
        /// </summary>
        /// <param name="traceSource">Trace source instance to utilize.</param>
        public TranslateCommand(TraceSource traceSource)
        {
            // This optional TraceSource can be used for logging in the command. You can use dependency injection to access
            // other services here as well.
            this.logger = Requires.NotNull(traceSource, nameof(traceSource));
        }

        /// <inheritdoc />
        public override CommandConfiguration CommandConfiguration => new(displayName: DisplayNameCustom)
        {
            // Use this object initializer to set optional parameters for the command. The required parameter,
            // displayName, is set above. To localize the displayName, add an entry in .vsextension\string-resources.json
            // and reference it here by passing "%TranslateExtension.TranslateCommand.DisplayName%" as a constructor parameter.
            Placements = [CommandPlacement.KnownPlacements.ExtensionsMenu],
            Icon = new(ImageMoniker.KnownValues.Extension, IconSettings.IconAndText),
        };

        /// <inheritdoc />
        public override Task InitializeAsync(CancellationToken cancellationToken)
        {
            // Use InitializeAsync for any one-time setup or initialization.
            return base.InitializeAsync(cancellationToken);
        }

        /// <inheritdoc />
        public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken cancellationToken)
        {
            var textSnapshot = await Extensibility.Editor().GetActiveTextViewAsync(context, cancellationToken);
            if (textSnapshot == null)
            {
                var document = textSnapshot?.Document;
                await this.Extensibility.Shell().ShowPromptAsync("No active textSnapshot found.", PromptOptions.OK, cancellationToken);
                return;
            }
            TextService textService = new TextService(textSnapshot);
            string selectedText = textService.GetSelectedText();
            //await this.Extensibility.Shell().ShowPromptAsync("Selected Text: \n" + selectedText , PromptOptions.OK, cancellationToken);

            TextTranslatorService textTranslator = new TextTranslatorService();
            string str = await textTranslator.TranslateTextAsync(selectedText);
            await this.Extensibility.Shell().ShowPromptAsync("Translated Text: \n" + str, PromptOptions.OK, cancellationToken);
        }
    }
}
