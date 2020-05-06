package com.jetbrains.rider.ideaInterop.fileTypes.pascal;

import com.jetbrains.rider.ideaInterop.fileTypes.RiderDummySyntaxHighlighter;

public class PascalSyntaxHighlighter extends RiderDummySyntaxHighlighter {

    public PascalSyntaxHighlighter() {
        super(PascalLanguage.INSTANCE);
    }
}
