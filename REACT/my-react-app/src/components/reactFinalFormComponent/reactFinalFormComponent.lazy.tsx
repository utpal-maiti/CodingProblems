import React, { lazy, Suspense } from 'react';

const LazyreactFinalFormComponent = lazy(() => import('./reactFinalFormComponent'));

const reactFinalFormComponent = (props: JSX.IntrinsicAttributes & { children?: React.ReactNode; }) => (
  <Suspense fallback={null}>
    <LazyreactFinalFormComponent {...props} />
  </Suspense>
);

export default reactFinalFormComponent;
