
// Set our sample toolbar.
FCKConfig.ToolbarSets['PluginTest'] = [
	['SourceSimple'],
	['My_Find','My_Replace','-','Placeholder'],
	['StyleSimple','FontFormatSimple','FontNameSimple','FontSizeSimple'],
	['Table','-','TableInsertRowAfter','TableDeleteRows','TableInsertColumnAfter','TableDeleteColumns','TableInsertCellAfter','TableDeleteCells','TableMergeCells','TableHorizontalSplitCell','TableCellProp'],
	['Bold','Italic','-','OrderedList','UnorderedList','-','Link','Unlink'],
	'/',
	['My_BigStyle','-','Smiley','-','About']
] ;

// Change the default plugin path.
FCKConfig.PluginsPath = FCKConfig.BasePath.substr(0, FCKConfig.BasePath.length - 7) + '_samples/_plugins/' ;

// Add our plugin to the plugins list.
//		FCKConfig.Plugins.Add( pluginName, availableLanguages )
//			pluginName: The plugin name. The plugin directory must match this name.
//			availableLanguages: a list of available language files for the plugin (separated by a comma).
FCKConfig.Plugins.Add( 'findreplace', 'en,fr,it' ) ;
FCKConfig.Plugins.Add( 'samples' ) ;

// If you want to use plugins found on other directories, just use the third parameter.
var sOtherPluginPath = FCKConfig.BasePath.substr(0, FCKConfig.BasePath.length - 7) + 'editor/plugins/' ;
FCKConfig.Plugins.Add( 'placeholder', 'de,en,es,fr,it,pl', sOtherPluginPath ) ;
FCKConfig.Plugins.Add( 'tablecommands', null, sOtherPluginPath ) ;
FCKConfig.Plugins.Add( 'simplecommands', null, sOtherPluginPath ) ;
