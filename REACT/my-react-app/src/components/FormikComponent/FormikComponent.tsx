import React, { FC } from 'react';
import { FormikComponentWrapper } from './FormikComponent.styled';
import { Formik, Field, Form } from 'formik';

interface FormikComponentProps {}

const FormikComponent: FC<FormikComponentProps> = () => (
	<FormikComponentWrapper data-testid="FormikComponent">
		<div className="App">
			{' '}
			<h1>Contact Us</h1>{' '}
			<Formik
				initialValues={{ name: '', email: '' }}
				onSubmit={async (values) => {
					await new Promise((resolve) => setTimeout(resolve, 500));
					alert(JSON.stringify(values, null, 2));
				}}
			>
				{' '}
				<Form>
					{' '}
					<Field name="name" type="text" /> <Field name="email" type="email" />{' '}
					<button type="submit">Submit</button>{' '}
				</Form>{' '}
			</Formik>{' '}
		</div>
	</FormikComponentWrapper>
);

export default FormikComponent;
