﻿namespace SpecSalad
{
    public abstract class ApplicationTask : TaskBase
    {
        public dynamic Role { get; set; }
        public Details Details { get; set; }
        
        public abstract object Perform_Task();
    }
}