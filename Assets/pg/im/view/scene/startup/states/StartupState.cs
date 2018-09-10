﻿using pg.core;
using pg.im.model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace pg.im.view
{
    public partial class StartupMediator
    {
        public class StartupState : StateBehaviour
        {
            protected readonly StartupMediator Mediator;
            protected readonly StartupModel StartupModel;
            protected readonly StartupView View;

            public StartupState(StartupMediator mediator)
            {
                this.Mediator = mediator;
                this.StartupModel = mediator._startupModel;
                this.View = mediator._view;
            }
        }
    }
}
