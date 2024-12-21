import React, { lazy, Suspense } from 'react';

const LazyFormikComponent = lazy(() => import('./FormikComponent'));

const FormikComponent = (props: JSX.IntrinsicAttributes & { children?: React.ReactNode; }) => (
  <Suspense fallback={null}>
    <LazyFormikComponent {...props} />
  </Suspense>
);

export default FormikComponent;
