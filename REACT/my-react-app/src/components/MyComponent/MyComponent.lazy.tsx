import React, { lazy, Suspense } from 'react';
import { MyComponentPropsLazy } from './MyComponent.Props';

const LazyMyComponent = lazy(() => import('./MyComponent'));

const MyComponent = (
	props: MyComponentPropsLazy & { children?: React.ReactNode }
) => (
	<Suspense fallback={null}>
		<LazyMyComponent {...props} />
	</Suspense>
);

export default MyComponent;
