﻿using System;

namespace NAutowired.Core {

  [AttributeUsage(AttributeTargets.Class)]
  public class FilterAttribute : Attribute {
    public DependencyInjectionModeEnum DependencyInjectionMode {
      get;
    } = DependencyInjectionModeEnum.Scoped;

    public FilterAttribute() {
    }


    public FilterAttribute(DependencyInjectionModeEnum dependencyInjectionMode) {
      this.DependencyInjectionMode = dependencyInjectionMode;
    }
  }
}
