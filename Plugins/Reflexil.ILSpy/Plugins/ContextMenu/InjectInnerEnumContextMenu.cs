﻿using ICSharpCode.ILSpy;
using ICSharpCode.TreeView;
using Reflexil.Utils;

namespace Reflexil.Plugins.ILSpy.ContextMenu
{
	[ExportContextMenuEntry(Icon = "resources/injectinnerenum.png", Header = "Inject inner enum", Category = "ReflexilTInnerInject")]
    internal class InjectInnerEnumContextMenu : BaseTypeDefinitionContextMenu
    {
		public override void Execute(TextViewContext context)
		{
			PreserveNodeSelection(context, () => base.Execute(context));
		}

		protected override void Execute(SharpTreeNode node)
        {
			ILSpyPackage.Inject(InjectType.Enum);
        }
    }
}
