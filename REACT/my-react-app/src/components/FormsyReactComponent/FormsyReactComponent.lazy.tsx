import React, { lazy, Suspense } from 'react';

const LazyFormsyReactComponent = lazy(() => import('./FormsyReactComponent'));

const FormsyReactComponent = (props: JSX.IntrinsicAttributes & { children?: React.ReactNode; }) => (
  <Suspense fallback={null}>
    <LazyFormsyReactComponent {...props} />
  </Suspense>
);

export default FormsyReactComponent;
