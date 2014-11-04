using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Microsoft.Design", "CA2210:AssembliesShouldHaveValidStrongNames")]
[assembly: SuppressMessage("Microsoft.Usage", "CA2243:AttributeStringLiteralsShouldParseCorrectly")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods", Scope = "member", Target = "Microsoft.Data.Domain.Submit.ChangeSetEntry.#Type")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Microsoft.Data.Domain.Submit.DataModificationEntry.#ServerValues")]
[assembly: SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "DataModificationEntry", Scope = "member", Target = "Microsoft.Data.Domain.Submit.DataModificationEntry.#ApplyTo(System.Linq.IQueryable)")]
[assembly: SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "IsNew", Scope = "member", Target = "Microsoft.Data.Domain.Submit.DataModificationEntry.#ApplyTo(System.Linq.IQueryable)")]
[assembly: SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "ApplyTo", Scope = "member", Target = "Microsoft.Data.Domain.Submit.DataModificationEntry.#ApplyTo(System.Linq.IQueryable)")]
[assembly: SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "EntityKey", Scope = "member", Target = "Microsoft.Data.Domain.Submit.DataModificationEntry.#ApplyTo(System.Linq.IQueryable)")]
[assembly: SuppressMessage("Microsoft.Globalization", "CA1307:SpecifyStringComparison", MessageId = "System.String.StartsWith(System.String)", Scope = "member", Target = "Microsoft.Data.Domain.Submit.DataModificationEntry.#ApplyTo(System.Linq.IQueryable)")]
[assembly: SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "IsDelete", Scope = "member", Target = "Microsoft.Data.Domain.Submit.DefaultSubmitHandler.#GetAuthorizeFailedMessage(Microsoft.Data.Domain.Submit.ChangeSetEntry)")]
[assembly: SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "IsUpdate", Scope = "member", Target = "Microsoft.Data.Domain.Submit.DefaultSubmitHandler.#GetAuthorizeFailedMessage(Microsoft.Data.Domain.Submit.ChangeSetEntry)")]
[assembly: SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "IsNew", Scope = "member", Target = "Microsoft.Data.Domain.Submit.DefaultSubmitHandler.#GetAuthorizeFailedMessage(Microsoft.Data.Domain.Submit.ChangeSetEntry)")]
[assembly: SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "DataModification", Scope = "member", Target = "Microsoft.Data.Domain.Submit.DefaultSubmitHandler.#GetAuthorizeFailedMessage(Microsoft.Data.Domain.Submit.ChangeSetEntry)")]
[assembly: SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", MessageId = "System.String.Format(System.String,System.Object)", Scope = "member", Target = "Microsoft.Data.Domain.Submit.DefaultSubmitHandler.#GetAuthorizeFailedMessage(Microsoft.Data.Domain.Submit.ChangeSetEntry)")]
[assembly: SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "ChangeSetEntry", Scope = "member", Target = "Microsoft.Data.Domain.Submit.DefaultSubmitHandler.#GetAuthorizeFailedMessage(Microsoft.Data.Domain.Submit.ChangeSetEntry)")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1724:TypeNamesShouldNotMatchNamespaces", Scope = "type", Target = "Microsoft.Data.Domain.Domain")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Microsoft.Data.Domain.Domain.#GetModelAsync(Microsoft.Data.Domain.IDomain,System.Threading.CancellationToken)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Microsoft.Data.Domain.Domain.#GetModelAsync(Microsoft.Data.Domain.DomainContext,System.Threading.CancellationToken)")]
[assembly: SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly", Scope = "member", Target = "Microsoft.Data.Domain.Domain.#Source`1(Microsoft.Data.Domain.DomainContext,System.String,System.Object[])")]
[assembly: SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly", Scope = "member", Target = "Microsoft.Data.Domain.Domain.#Source`1(Microsoft.Data.Domain.DomainContext,System.String,System.String,System.Object[])")]
[assembly: SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Microsoft.Data.Domain.Domain.#QueryAsync`1(Microsoft.Data.Domain.IDomain,System.Linq.IQueryable`1<!!0>,System.Threading.CancellationToken)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Microsoft.Data.Domain.Domain.#QueryAsync`1(Microsoft.Data.Domain.IDomain,System.Linq.IQueryable`1<!!0>,System.Threading.CancellationToken)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Microsoft.Data.Domain.Domain.#QueryAsync`2(Microsoft.Data.Domain.IDomain,System.Linq.IQueryable`1<!!0>,System.Linq.Expressions.Expression`1<System.Func`2<System.Linq.IQueryable`1<!!0>,!!1>>,System.Threading.CancellationToken)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Microsoft.Data.Domain.Domain.#QueryAsync`2(Microsoft.Data.Domain.IDomain,System.Linq.IQueryable`1<!!0>,System.Linq.Expressions.Expression`1<System.Func`2<System.Linq.IQueryable`1<!!0>,!!1>>,System.Threading.CancellationToken)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Microsoft.Data.Domain.Domain.#QueryAsync(Microsoft.Data.Domain.IDomain,Microsoft.Data.Domain.Query.QueryRequest,System.Threading.CancellationToken)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Microsoft.Data.Domain.Domain.#QueryAsync(Microsoft.Data.Domain.DomainContext,Microsoft.Data.Domain.Query.QueryRequest,System.Threading.CancellationToken)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Microsoft.Data.Domain.Domain.#SubmitAsync(Microsoft.Data.Domain.IDomain,Microsoft.Data.Domain.Submit.ChangeSet,System.Threading.CancellationToken)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Microsoft.Data.Domain.Domain.#SubmitAsync(Microsoft.Data.Domain.DomainContext,Microsoft.Data.Domain.Submit.ChangeSet,System.Threading.CancellationToken)")]
[assembly: SuppressMessage("Microsoft.Web.FxCop", "MW1100:DoNotUseFinalizersRule", Scope = "member", Target = "Microsoft.Data.Domain.DomainBase.#Finalize()")]
[assembly: SuppressMessage("Microsoft.Design", "CA1063:ImplementIDisposableCorrectly", Scope = "member", Target = "Microsoft.Data.Domain.DomainBase.#Dispose()")]
[assembly: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Microsoft.Data.Domain.DomainBase.#Microsoft.Data.Domain.IExpandableDomain.Configuration")]
[assembly: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Microsoft.Data.Domain.DomainBase.#Microsoft.Data.Domain.IExpandableDomain.IsInitialized")]
[assembly: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Microsoft.Data.Domain.DomainBase.#Microsoft.Data.Domain.IDomain.Context")]
[assembly: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Microsoft.Data.Domain.DomainBase.#Microsoft.Data.Domain.IExpandableDomain.Initialize(Microsoft.Data.Domain.DomainConfiguration)")]
[assembly: SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly", Scope = "member", Target = "Microsoft.Data.Domain.DomainBase.#Microsoft.Data.Domain.IExpandableDomain.Initialize(Microsoft.Data.Domain.DomainConfiguration)")]
[assembly: SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly", Scope = "member", Target = "Microsoft.Data.Domain.DomainConfiguration.#SetHookPoint(System.Type,System.Object)")]
[assembly: SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly", Scope = "member", Target = "Microsoft.Data.Domain.DomainConfiguration.#AddHookPoint(System.Type,System.Object)")]
[assembly: SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly", Scope = "member", Target = "Microsoft.Data.Domain.DomainContext.#.ctor(Microsoft.Data.Domain.DomainConfiguration)")]
[assembly: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "name", Scope = "member", Target = "Microsoft.Data.Domain.DomainData.#Source`1(System.String,System.Object[])")]
[assembly: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "arguments", Scope = "member", Target = "Microsoft.Data.Domain.DomainData.#Source`1(System.String,System.Object[])")]
[assembly: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "namespaceName", Scope = "member", Target = "Microsoft.Data.Domain.DomainData.#Source`1(System.String,System.String,System.Object[])")]
[assembly: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "name", Scope = "member", Target = "Microsoft.Data.Domain.DomainData.#Source`1(System.String,System.String,System.Object[])")]
[assembly: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "arguments", Scope = "member", Target = "Microsoft.Data.Domain.DomainData.#Source`1(System.String,System.String,System.Object[])")]
[assembly: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "name", Scope = "member", Target = "Microsoft.Data.Domain.DomainData.#Results`1(System.String,System.Object[])")]
[assembly: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "arguments", Scope = "member", Target = "Microsoft.Data.Domain.DomainData.#Results`1(System.String,System.Object[])")]
[assembly: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "name", Scope = "member", Target = "Microsoft.Data.Domain.DomainData.#Result`1(System.String,System.Object[])")]
[assembly: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "arguments", Scope = "member", Target = "Microsoft.Data.Domain.DomainData.#Result`1(System.String,System.Object[])")]
[assembly: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "namespaceName", Scope = "member", Target = "Microsoft.Data.Domain.DomainData.#Results`1(System.String,System.String,System.Object[])")]
[assembly: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "name", Scope = "member", Target = "Microsoft.Data.Domain.DomainData.#Results`1(System.String,System.String,System.Object[])")]
[assembly: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "arguments", Scope = "member", Target = "Microsoft.Data.Domain.DomainData.#Results`1(System.String,System.String,System.Object[])")]
[assembly: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "namespaceName", Scope = "member", Target = "Microsoft.Data.Domain.DomainData.#Result`1(System.String,System.String,System.Object[])")]
[assembly: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "name", Scope = "member", Target = "Microsoft.Data.Domain.DomainData.#Result`1(System.String,System.String,System.Object[])")]
[assembly: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "arguments", Scope = "member", Target = "Microsoft.Data.Domain.DomainData.#Result`1(System.String,System.String,System.Object[])")]
[assembly: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "source", Scope = "member", Target = "Microsoft.Data.Domain.DomainData.#Value`1(System.Object,System.String)")]
[assembly: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "propertyName", Scope = "member", Target = "Microsoft.Data.Domain.DomainData.#Value`1(System.Object,System.String)")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Linq.Expressions.ExpressionHelperMethods.#QueryableSelectGeneric")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Linq.Expressions.ExpressionHelperMethods.#QueryableSelectManyGeneric")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Linq.Expressions.ExpressionHelpers.#Select(System.Linq.IQueryable,System.Linq.Expressions.LambdaExpression)")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Linq.Expressions.ExpressionHelpers.#SelectMany(System.Linq.IQueryable,System.Linq.Expressions.LambdaExpression,System.Type)")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Linq.Expressions.ExpressionHelpers.#GetEnumerableItemType(System.Type)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Scope = "member", Target = "Microsoft.Data.Domain.Query.IQueryExecutor.#ExecuteSingleAsync`1(Microsoft.Data.Domain.Query.QueryContext,System.Linq.IQueryable,System.Linq.Expressions.Expression,System.Threading.CancellationToken)")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Sourcer", Scope = "type", Target = "Microsoft.Data.Domain.Query.IQueryExpressionSourcer")]
[assembly: SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly", Scope = "member", Target = "Microsoft.Data.Domain.QueryableSource.#System.Linq.IQueryProvider.CreateQuery`1(System.Linq.Expressions.Expression)")]
[assembly: SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly", Scope = "member", Target = "Microsoft.Data.Domain.QueryableSource.#System.Linq.IQueryProvider.CreateQuery(System.Linq.Expressions.Expression)")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods", Scope = "member", Target = "Microsoft.Data.Domain.Query.QueryExpressionContext.#ModelReference")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Microsoft.Data.Domain.Query.QueryExpressionContext.#ComputeDerivedDataReference(System.Linq.Expressions.MethodCallExpression,Microsoft.Data.Domain.Query.QueryModelReference)")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Microsoft.Data.Domain.Query.QueryExpressionContext.#ComputeChildDataReference()")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Microsoft.Data.Domain.Query.QueryExpressionContext.#ComputeChildDataReference()")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods", Scope = "member", Target = "Microsoft.Data.Domain.Query.QueryModelReference.#Type")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Microsoft.Data.Domain.Query.QueryRequest.#.ctor(System.Linq.IQueryable,System.Nullable`1<System.Boolean>)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Microsoft.Data.Domain.Query.QueryRequest.#Create`2(System.Linq.IQueryable`1<!!0>,System.Linq.Expressions.Expression`1<System.Func`2<System.Linq.IQueryable`1<!!0>,!!1>>,System.Nullable`1<System.Boolean>)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Microsoft.Data.Domain.Query.QueryRequest.#Create`2(System.Linq.IQueryable`1<!!0>,System.Linq.Expressions.Expression`1<System.Func`2<System.Linq.IQueryable`1<!!0>,!!1>>,System.Nullable`1<System.Boolean>)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "Microsoft.Data.Domain.Query.QueryRequest.#Create`2(System.Linq.IQueryable`1<!!0>,System.Linq.Expressions.Expression`1<System.Func`2<System.Linq.IQueryable`1<!!0>,!!1>>,System.Nullable`1<System.Boolean>)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Microsoft.Data.Domain.Query.QueryRequest.#Create(System.Linq.IQueryable,System.Linq.Expressions.LambdaExpression,System.Nullable`1<System.Boolean>)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Microsoft.Data.Domain.Query.QueryResult.#.ctor(System.Collections.IEnumerable,System.Nullable`1<System.Int64>)")]
[assembly: SuppressMessage("Microsoft.Usage", "CA2237:MarkISerializableTypesWithSerializable", Scope = "type", Target = "Microsoft.Data.Domain.Submit.ValidationException")]
[assembly: SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors", Scope = "type", Target = "Microsoft.Data.Domain.Submit.ValidationException")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix", Scope = "type", Target = "Microsoft.Data.Domain.Submit.ValidationResults")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1804:RemoveUnusedLocals", MessageId = "itemValue", Scope = "member", Target = "Microsoft.Data.Domain.Submit.DataModificationEntry.#ApplyPredicate(System.Linq.Expressions.ParameterExpression,System.Linq.Expressions.Expression,System.Collections.Generic.KeyValuePair`2<System.String,System.Object>)")]
[assembly: SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "ChangeSetEntry", Scope = "member", Target = "Microsoft.Data.Domain.Conventions.ConventionalChangeSetEntryFilter.#GetParameters(Microsoft.Data.Domain.Submit.ChangeSetEntry)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Microsoft.Data.Domain")]
[assembly: SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "ChangeSetEntry", Scope = "member", Target = "Microsoft.Data.Domain.Conventions.ConventionalChangeSetAuthorizer.#GetAuthorizeMethodName(Microsoft.Data.Domain.Submit.ChangeSetEntry)")]
[assembly: SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "ChangeSetEntry", Scope = "member", Target = "Microsoft.Data.Domain.Conventions.ConventionalChangeSetEntryFilter.#GetMethodName(Microsoft.Data.Domain.Submit.ChangeSetEntry,System.String)")]
[assembly: SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Scope = "member", Target = "Microsoft.Data.Domain.Conventions.ConventionalChangeSetEntryValidator.#Instance")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1813:AvoidUnsealedAttributes", Scope = "type", Target = "Microsoft.Data.Domain.EnableConventionsAttribute")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Ensure.#NotNull`1(System.Nullable`1<!!0>,System.String)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Microsoft.Data.Domain.EntityFramework.Model")]
[assembly: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Microsoft.Data.Domain.EntityFramework.Query")]
[assembly: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Microsoft.Data.Domain.EntityFramework.Submit")]
[assembly: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Microsoft.Data.Domain.EntityFramework")]
[assembly: SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Scope = "member", Target = "Microsoft.Data.Domain.EntityFramework.Submit.ChangeSetPreparer.#Instance")]
[assembly: SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Scope = "member", Target = "Microsoft.Data.Domain.EntityFramework.Model.ModelProducer.#Instance")]
[assembly: SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Scope = "member", Target = "Microsoft.Data.Domain.EntityFramework.Model.ModelProducer.#ProduceModelAsync(Microsoft.Data.Domain.Model.ModelContext,System.Threading.CancellationToken)")]
[assembly: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "model", Scope = "member", Target = "Microsoft.Data.Domain.EntityFramework.Model.ModelProducer.#AddNavigationProperties(System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace,System.Data.Entity.Core.Metadata.Edm.AssociationSet,Microsoft.OData.Edm.Library.EdmModel,System.Collections.Generic.IDictionary`2<System.Data.Entity.Core.Metadata.Edm.MetadataItem,Microsoft.OData.Edm.IEdmElement>)")]
[assembly: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "efModel", Scope = "member", Target = "Microsoft.Data.Domain.EntityFramework.Model.ModelProducer.#AddNavigationProperties(System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace,System.Data.Entity.Core.Metadata.Edm.AssociationSet,Microsoft.OData.Edm.Library.EdmModel,System.Collections.Generic.IDictionary`2<System.Data.Entity.Core.Metadata.Edm.MetadataItem,Microsoft.OData.Edm.IEdmElement>)")]
[assembly: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "model", Scope = "member", Target = "Microsoft.Data.Domain.EntityFramework.Model.ModelProducer.#AddNavigationPropertyBindings(System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace,System.Data.Entity.Core.Metadata.Edm.AssociationSet,Microsoft.OData.Edm.Library.EdmModel,System.Collections.Generic.IDictionary`2<System.Data.Entity.Core.Metadata.Edm.MetadataItem,Microsoft.OData.Edm.IEdmElement>)")]
[assembly: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "efModel", Scope = "member", Target = "Microsoft.Data.Domain.EntityFramework.Model.ModelProducer.#AddNavigationPropertyBindings(System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace,System.Data.Entity.Core.Metadata.Edm.AssociationSet,Microsoft.OData.Edm.Library.EdmModel,System.Collections.Generic.IDictionary`2<System.Data.Entity.Core.Metadata.Edm.MetadataItem,Microsoft.OData.Edm.IEdmElement>)")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1804:RemoveUnusedLocals", MessageId = "efAssociation", Scope = "member", Target = "Microsoft.Data.Domain.EntityFramework.Model.ModelProducer.#AddNavigationPropertyBindings(System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace,System.Data.Entity.Core.Metadata.Edm.AssociationSet,Microsoft.OData.Edm.Library.EdmModel,System.Collections.Generic.IDictionary`2<System.Data.Entity.Core.Metadata.Edm.MetadataItem,Microsoft.OData.Edm.IEdmElement>)")]
[assembly: SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Scope = "member", Target = "Microsoft.Data.Domain.EntityFramework.Query.QueryExecutor.#Instance")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Sourcer", Scope = "type", Target = "Microsoft.Data.Domain.EntityFramework.Query.QueryExpressionSourcer")]
[assembly: SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Scope = "member", Target = "Microsoft.Data.Domain.EntityFramework.Query.QueryExpressionSourcer.#Instance")]
[assembly: SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Scope = "member", Target = "Microsoft.Data.Domain.EntityFramework.Submit.SubmitExecutor.#Instance")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix", Scope = "type", Target = "Microsoft.Data.Domain.Security.DomainPermission")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1813:AvoidUnsealedAttributes", Scope = "type", Target = "Microsoft.Data.Domain.Security.AssertAttribute")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1813:AvoidUnsealedAttributes", Scope = "type", Target = "Microsoft.Data.Domain.Security.DenyAttribute")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Microsoft.Data.Domain.Security.DomainPermission.#CreateGrant(System.String,System.String,System.String,System.String,System.String)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Microsoft.Data.Domain.Security.DomainPermission.#CreateDeny(System.String,System.String,System.String,System.String,System.String)")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1813:AvoidUnsealedAttributes", Scope = "type", Target = "Microsoft.Data.Domain.Security.EnableRoleBasedSecurityAttribute")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1813:AvoidUnsealedAttributes", Scope = "type", Target = "Microsoft.Data.Domain.Security.GrantAttribute")]
[assembly: SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Scope = "member", Target = "Microsoft.Data.Domain.Security.RoleBasedAuthorization.#Default")]
[assembly: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "System.Web.OData.Domain.Results")]
[assembly: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "System.Web.OData.Domain.Formatter.Serialization")]
[assembly: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "System.Web.OData.Domain.Routing")]
[assembly: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "System.Web.OData.Domain.Filters")]
[assembly: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "System.Web.OData.Domain.Batch")]
[assembly: SuppressMessage("Microsoft.Globalization", "CA1307:SpecifyStringComparison", MessageId = "System.String.EndsWith(System.String)", Scope = "member", Target = "System.Web.OData.Domain.Routing.DefaultODataRoutingConvention.#.ctor(System.String)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Scope = "member", Target = "System.Web.OData.Domain.HttpConfigurationExtensions.#MapODataDomainRoute`1(System.Web.Http.HttpConfiguration,System.String,System.String,System.Web.OData.Domain.Batch.ODataDomainBatchHandler)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "System.Web.OData.Domain.HttpConfigurationExtensions.#MapODataDomainRoute`1(System.Web.Http.HttpConfiguration,System.String,System.String,System.Web.OData.Domain.Batch.ODataDomainBatchHandler)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "System.Web.OData.Domain.Batch.ODataDomainBatchHandler.#.ctor(System.Web.Http.HttpServer,System.Func`1<Microsoft.Data.Domain.DomainContext>)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1061:DoNotHideBaseClassMethods", Scope = "member", Target = "System.Web.OData.Domain.Batch.ODataDomainChangeSetRequestItem.#DisposeResponses(System.Collections.Generic.IEnumerable`1<System.Net.Http.HttpResponseMessage>)")]
[assembly: SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Scope = "type", Target = "System.Web.OData.Domain.ODataDomainController`1")]
[assembly: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "odataProperties", Scope = "member", Target = "System.Web.OData.Domain.ODataDomainController`1.#GetQuery(System.Web.OData.Extensions.HttpRequestMessageProperties)")]
[assembly: SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "System.Net.Http.HttpRequestMessageExtensions.CreateErrorResponse(System.Net.Http.HttpRequestMessage,System.Net.HttpStatusCode,System.String)", Scope = "member", Target = "System.Web.OData.Domain.ODataDomainController`1.#GetQuery(System.Web.OData.Extensions.HttpRequestMessageProperties)")]
[assembly: SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "System.Web.OData.Domain.ODataDomainController`1.#GetQuery(System.Web.OData.Extensions.HttpRequestMessageProperties)")]
[assembly: SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "ODataProperties", Scope = "member", Target = "System.Web.OData.Domain.ODataDomainController`1.#GetPath()")]
[assembly: SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "ODataPath", Scope = "member", Target = "System.Web.OData.Domain.ODataDomainController`1.#GetPath()")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily", Scope = "member", Target = "System.Web.OData.Domain.ODataDomainController`1.#GetSource(System.Web.OData.Routing.ODataPath,Microsoft.OData.Edm.IEdmEntityType&)")]
[assembly: SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "KeyValue", Scope = "member", Target = "System.Web.OData.Domain.ODataDomainController`1.#GetPathKeyValues(System.Web.OData.Routing.KeyValuePathSegment,Microsoft.OData.Edm.IEdmEntityType)")]
[assembly: SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "KeyName", Scope = "member", Target = "System.Web.OData.Domain.ODataDomainController`1.#GetPathKeyValues(System.Web.OData.Routing.KeyValuePathSegment,Microsoft.OData.Edm.IEdmEntityType)")]
[assembly: SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", MessageId = "System.String.Format(System.String,System.Object,System.Object)", Scope = "member", Target = "System.Web.OData.Domain.ODataDomainController`1.#GetPathKeyValues(System.Web.OData.Routing.KeyValuePathSegment,Microsoft.OData.Edm.IEdmEntityType)")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "System.Web.OData.Domain.ODataDomainController`1.#ApplyNavigation(System.Linq.IQueryable,System.Web.OData.Routing.NavigationPathSegment,Microsoft.OData.Edm.IEdmEntityType&,System.Type&)")]
[assembly: SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "TypeReference", Scope = "member", Target = "System.Web.OData.Domain.ODataDomainController`1.#GetTypeReference(Microsoft.OData.Edm.IEdmType)")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "System.Web.OData.Domain.ODataDomainController`1.#GetPathKeyValues(System.Web.OData.Routing.ODataPath)")]
[assembly: SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "entityset", Scope = "member", Target = "System.Web.OData.Domain.ODataDomainController`1.#GetPathKeyValues(System.Web.OData.Routing.ODataPath)")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1813:AvoidUnsealedAttributes", Scope = "type", Target = "System.Web.OData.Domain.Filters.ODataDomainExceptionFilterAttribute")]
[assembly: SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "EntitySet", Scope = "member", Target = "System.Web.OData.Domain.Formatter.Serialization.ODataDomainFeedSerializer.#WriteObject(System.Object,System.Type,Microsoft.OData.Core.ODataMessageWriter,System.Web.OData.Formatter.Serialization.ODataSerializerContext)")]
[assembly: SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", MessageId = "System.String.Format(System.String,System.Object,System.Object)", Scope = "member", Target = "System.Web.OData.Domain.Formatter.Serialization.ODataDomainFeedSerializer.#GetEntityType(Microsoft.OData.Edm.IEdmTypeReference)")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1813:AvoidUnsealedAttributes", Scope = "type", Target = "System.Web.OData.Domain.ODataDomainFormattingAttribute")]
