package Client_CopyLinks
{
	function GuiMLTextCtrl::onURL(%this,%url,%a,%b)
	{
		if(!$Pref::copyLinks)
			parent::onUrl(%this,%url,%a,%b);
		else
		{
			setClipBoard(%url);
			newChatHud_AddLine("\c6Copied to clipboard: "@ %url);
		}
	}
};
activatePackage(Client_copyLinks);

if($Pref::copyLinks $= "")
	$pref::copyLinks = 1;