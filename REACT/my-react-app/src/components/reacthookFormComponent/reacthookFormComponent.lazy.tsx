import React, { lazy, Suspense } from 'react';

const LazyreacthookFormComponent = lazy(() => import('./reacthookFormComponent'));

const reacthookFormComponent = (props: JSX.IntrinsicAttributes & { children?: React.ReactNode; }) => (
  <Suspense fallback={null}>
    <LazyreacthookFormComponent {...props} />
  </Suspense>
);

export default reacthookFormComponent;
