装饰者模式实践

#### 场景
> 订单通过分配后产生运单（生成运单或绑定到已存在的运单），订单分为7种类型，每种分配的流程和规则各有异同。

一开始我直接是一个方法往下写，结果功能是实现了但是一个方法大概600行代码，后面维护的时候很麻烦，经常因为改一个场景就要影响其他场景，而且改过后就要全场景进行回归测试，代码很不稳定，维护和测试的成本很高。

经过对业务的梳理和抽象，发现装饰者模式非常适合解决这个问题，就开始对这部分业务进行改造。

#### 项目结构1.0：

```

/MyProject
|__/Opeartor
   |__IOpeartor.cs
   |__FirstOpeartor
   |__SecondOpeartor.cs
|__/Deal
   |__IDealShipment.cs
   |__FirstDealShipment.cs
   |__SecondDealShipment.cs
|__DealShipmentFactory.cs

```

> /Opeartor 下主要声明和实现各个场景的子流程（各种子装饰方法）

> /Deal 下主要声明和实现各个场景，并对对应Opeartor的子流程进行排列组合（各种装饰风格）

> DealShipmentFactory.cs 工厂类（产出特定装饰风格）


最初看来，也是可以解决问题的，但是后面发现分单的步骤有一些是一样的，比如订单状态验证，时间条件验证，成功订单状态更改等，而且实现也一模一样，这时候Opeartor里的类会有很多冗余代码，这时候我们就采用了抽象类来解决冗余问题，引入了AbstractOpeartor类，把上面提到的冗余方法定义成虚方法提供默认实现，这样一方面降低了代码冗余，一方面就算后面业务变更，也可以在自定的Opeartor里重写自己的实现。

#### 项目结构2.0：

```
/MyProject
|__/Opeartor
   |__IOpeartor.cs
   |__AbstractOpeartor.cs   
   |__FirstOpeartor
   |__SecondOpeartor.cs
|__/Deal
   |__IDealShipment.cs
   |__FirstDealShipment.cs
   |__SecondDealShipment.cs
|__DealShipmentFactory.cs

```
