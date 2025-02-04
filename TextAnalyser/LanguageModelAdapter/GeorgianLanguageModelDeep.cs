﻿using System;
using TextMarkovChains;

namespace LanguageModelAdapter
{
    public class GeorgianLanguageModelDeep : ChainAdapter<MultiDeepMarkovChain>
    {
        protected override string XmlFileName { get; } = "geo_model_deep.xml";
        protected override Action<int> FileBeingLoadedLogger { get; }//TODO
        protected override IMarkovChain InitializeChain() => new MultiDeepMarkovChain(3);
    }

}