import React, { FC } from 'react';
import { ReactHookFormComponentWrapper } from './reacthookFormComponent.styled';
import { useForm } from 'react-hook-form';

interface reacthookFormComponentProps {}

const ReactHookFormComponent: FC<reacthookFormComponentProps> = () => {
	const { register, handleSubmit, errors } = useForm();
	const onSubmit = (data) => {
		alert(JSON.stringify(data));
	};

	return (
		<ReactHookFormComponentWrapper data-testid="reacthookFormComponent">
			<div className="App">
				{' '}
				<h1>Sign Up</h1>{' '}
				<form onSubmit={handleSubmit(onSubmit)}>
					{' '}
					<label htmlFor="firstName">First Name</label>{' '}
					<input {...register('firstName')} placeholder="John" />{' '}
					{errors.firstName && <span>This field is required</span>}{' '}
					<label htmlFor="lastName">Last Name</label>{' '}
					<input {...register('lastName')} placeholder="Doe" />{' '}
					{errors.lastName && <span>This field is required</span>}{' '}
					<label htmlFor="email">Email</label>{' '}
					<input
						{...register('email', { required: true, pattern: /^\S+@\S+$/i })}
						placeholder="john@acme.com"
					/>{' '}
					{errors.email && <span>Please enter a valid email address</span>}{' '}
					<button type="submit">Submit</button>{' '}
				</form>{' '}
			</div>
		</ReactHookFormComponentWrapper>
	);
};

export default reacthookFormComponent;
